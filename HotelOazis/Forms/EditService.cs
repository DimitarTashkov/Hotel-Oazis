using Fitness.Utilities;
using HotelOazis.DTOs.Room;
using HotelOazis.DTOs.Service;
using HotelOazis.Extensions;
using HotelOazis.Models.Enumerations;
using HotelOazis.Models;
using HotelOazis.Services.Interfaces;
using HotelOazis.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static HotelOazis.Common.Messages.ErrorMessages.InputsMessages;
using static HotelOazis.Common.Messages.ResultMessages.ActionMessages;
using HotelOazis.Common.Constants;
using Fitness.Services;

namespace HotelOazis.Forms
{
    public partial class EditService : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly IReviewService reviewService;
        private readonly IRoomService roomService;
        private readonly EditServiceInputModel model;
        private User activeUser;
        public EditService(IFacilityService facilityService, EditServiceInputModel model)
        {
            this.model = model;
            this.facilityService = facilityService;
            this.userService = ServiceLocator.GetService<IUserService>();
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            this.roomService = ServiceLocator.GetService<IRoomService>();
            activeUser = userService.GetLoggedInUserAsync();

            InitializeComponent();

            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);

            nameField.TextChanged += EventsEffects.input_TextChanged;
            nameField.Click += EventsEffects.clearInputs_click;
            descriptionField.TextChanged += EventsEffects.input_TextChanged;
            descriptionField.Click += EventsEffects.clearInputs_click;
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Services servicesForm = new Services(facilityService, userService);
            Program.SwitchMainForm(servicesForm);
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {
            List<TextBox> inputs = new List<TextBox>
            {
                nameField,
                descriptionField,
            };
            bool areInputsValid = ValidationHelper.ValidateUserInputs(inputs);
            if (!areInputsValid)
            {
                MessageBox.Show(EmptyInputData, "Room Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var editModel = new EditServiceInputModel()
            {
                Id = model.Id,
                Name = nameField.Text,
                Description = descriptionField.Text
            };

            var (isValid, errors) = await userService.ValidateModelAsync(editModel);
            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(editModel.Name)))
                    {
                        nameErrors.Text = error.ErrorMessage;
                        nameErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(editModel.Description)))
                    {
                        descriptionErrors.Text = error.ErrorMessage;
                        descriptionErrors.Visible = true;
                    }
                }
                return;
            }

            bool success = await facilityService.EditServiceAsync(editModel);
            if (success)
            {
                MessageBox.Show(string.Format(UpdatedSuccessfully, nameof(Service)), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EditService editServiceForm = new EditService(facilityService, editModel);
                Program.SwitchMainForm(editServiceForm);
            }
            else
            {
                MessageBox.Show(string.Format(UpdateFailed, nameof(Service)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            bool isAdmin = AuthorizationHelper.IsAuthorized();

            if (isAdmin)
            {
                Users.Visible = true;
                Reservations.Visible = true;
            }

            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;
            nameField.Text = model.Name;
            descriptionField.Text = model.Description;

            nameField.ForeColor = Color.DimGray;
            descriptionField.ForeColor = Color.DimGray;

            nameField.Font = FontsPicker.DetailsFont;
            descriptionField.Font = FontsPicker.DetailsFont;
        }
        private void menu_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            string formName = item.Text;
            Form form = new Form();

            switch (formName)
            {
                case "Rooms":
                    form = new Rooms(roomService, userService);
                    break;
                case "Services":
                    form = new Services(facilityService, userService);
                    break;
                case "Reviews":
                    form = new Reviews(reviewService, userService);
                    break;
                case "Profile":
                    form = new Profile(userService);
                    break;
                case "Users":
                    form = new Users(userService);
                    break;
                case "My reservations":
                    form = new Reservations(userService, roomService);
                    break;
                case "Reservations":
                    form = new Reservations(userService, roomService);
                    break;
                case "Home":
                    form = new Index(userService);
                    break;
                default:
                    form = new Index(userService);
                    break;
            }
            Program.SwitchMainForm(form);
        }
        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(userService);
            Program.SwitchMainForm(profileForm);
        }
    }
}
