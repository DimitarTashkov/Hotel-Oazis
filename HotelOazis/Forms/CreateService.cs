using Fitness.Utilities;
using HotelOazis.DTOs.Room;
using HotelOazis.Models.Enumerations;
using HotelOazis.Services.Interfaces;
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

using HotelOazis.DTOs.Service;
using HotelOazis.Models;
using Fitness.Services;
using HotelOazis.Extensions;
using HotelOazis.Utilities;

namespace HotelOazis.Forms
{
    public partial class CreateService : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly IReviewService reviewService;
        private readonly IRoomService roomService;
        private User activeUser;
        public CreateService(IUserService userService, IFacilityService facilityService)
        {
            this.userService = userService;
            this.facilityService = facilityService;
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            this.roomService = ServiceLocator.GetService<IRoomService>();
            activeUser = userService.GetLoggedInUserAsync();
            InitializeComponent();
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            createBtn.BackColor = Color.DarkGreen;

            List<TextBox> inputs = new List<TextBox>
            {
                nameField,
                descriptionField
            };

            bool areInputsValid = ValidationHelper.ValidateUserInputs(inputs);
            if (!areInputsValid)
            {
                MessageBox.Show(EmptyInputData, "Room Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string serviceName = nameField.Text;
            string serviceDescription = descriptionField.Text;

            ServiceInputModel serviceInputModel = new ServiceInputModel
            {
                Name = serviceName,
                Description = serviceDescription,
            };

            var (isValid, errors) = await facilityService.ValidateModelAsync(serviceInputModel);

            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(serviceInputModel.Name)))
                    {
                        nameErrors.Text = error.ErrorMessage;
                        nameErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(serviceInputModel.Description)))
                    {
                        descriptionErrors.Text = error.ErrorMessage;
                        descriptionErrors.Visible = true;
                    }
                }
                return;
            }

            bool isCreated = await facilityService.AddServiceAsync(serviceInputModel);
            if (isCreated)
            {
                MessageBox.Show(string.Format(CreatedSuccessfully, nameof(Service)), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Services servicesForm = new Services(facilityService, userService);
                Program.SwitchMainForm(servicesForm);
            }
            else
            {
                MessageBox.Show(string.Format(CreationFailed, nameof(Service)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Services servicesForm = new Services(facilityService, userService);
            Program.SwitchMainForm(servicesForm);
        }

        private void CreateService_Load(object sender, EventArgs e)
        {
            bool isAdmin = AuthorizationHelper.IsAuthorized();

            if (isAdmin)
            {
                Users.Visible = true;
                Reservations.Visible = true;
            }

            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;
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
