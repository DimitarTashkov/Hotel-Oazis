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
            InitializeComponent();
            this.model = model;
            this.facilityService = facilityService;
            this.userService = ServiceLocator.GetService<IUserService>();
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            this.roomService = ServiceLocator.GetService<IRoomService>();

            LoadUserDataAsync();
            ApplyStyles();
        }

        private void LoadUserDataAsync()
        {
            activeUser = userService.GetLoggedInUserAsync();
            roundPictureBox1.ImageLocation = activeUser?.AvatarUrl;
        }

        private void ApplyStyles()
        {
            this.BackColor = Color.FromArgb(245, 245, 245);

            // Стилове за бутони
            editBtn.BackColor = Color.FromArgb(39, 174, 96);
            editBtn.ForeColor = Color.White;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            editBtn.MouseEnter += (s, e) => editBtn.BackColor = Color.FromArgb(33, 154, 82);
            editBtn.MouseLeave += (s, e) => editBtn.BackColor = Color.FromArgb(39, 174, 96);

            navigationButton.BackColor = Color.FromArgb(149, 165, 166);
            navigationButton.ForeColor = Color.White;
            navigationButton.FlatStyle = FlatStyle.Flat;
            navigationButton.FlatAppearance.BorderSize = 0;
            navigationButton.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            navigationButton.MouseEnter += (s, e) => navigationButton.BackColor = Color.FromArgb(127, 140, 141);
            navigationButton.MouseLeave += (s, e) => navigationButton.BackColor = Color.FromArgb(149, 165, 166);

            // Стилове за текстови полета
            nameField.Font = new Font("Segoe UI", 11);
            descriptionField.Font = new Font("Segoe UI", 11);
            nameField.BackColor = Color.White;
            descriptionField.BackColor = Color.White;
            nameField.BorderStyle = BorderStyle.FixedSingle;
            descriptionField.BorderStyle = BorderStyle.FixedSingle;

            // Стилове за етикети
            nameLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            descriptionLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(44, 62, 80);
            descriptionLabel.ForeColor = Color.FromArgb(44, 62, 80);
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

            string formName = item.Name;
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
                case "MyReservations":
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