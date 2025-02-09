using Fitness.Utilities;
using HotelOazis.Common.Constants;
using HotelOazis.DTOs.User;
using HotelOazis.Models;
using HotelOazis.Services;
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

using static HotelOazis.Common.Messages.ResultMessages.UserMessages;
using static HotelOazis.Common.Messages.ErrorMessages.InputsMessages;
using static HotelOazis.Common.Constants.ValidationConstants.InputConstants;
using Microsoft.EntityFrameworkCore;
using static HotelOazis.Common.Messages.ErrorMessages;
using Fitness.Services;
using HotelOazis.Extensions;

namespace HotelOazis.Forms
{
    public partial class Profile : Form
    {
        private User activeUser;
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly IReviewService reviewService;
        private readonly IRoomService roomService;


        public Profile(IUserService userService)
        {
            ActiveControl = usernameLabel;

            InitializeComponent();
            activeUser = userService.GetLoggedInUserAsync();
            this.userService = userService;
            this.facilityService = ServiceLocator.GetService<IFacilityService>();
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            this.roomService = ServiceLocator.GetService<IRoomService>();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            bool isAdmin = AuthorizationHelper.IsAuthorized();

            if (isAdmin)
            {
                Users.Visible = true;
                Reservations.Visible = true;
            }

            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;

            usernameField.Text = activeUser.Username;
            foreach (var character in activeUser.Password)
            {
                passwordField.Text += "*";
            }

            emailField.Text = activeUser.Email;
            ageField.Text = activeUser.Age.ToString();
            profilePicture.ImageLocation = activeUser.AvatarUrl;

            emailField.ForeColor = Color.DimGray;
            ageField.ForeColor = Color.DimGray;
            usernameField.ForeColor = Color.DimGray;
            passwordField.ForeColor = Color.DimGray;

            emailField.Font = FontsPicker.DetailsFont;
            ageField.Font = FontsPicker.DetailsFont;
            usernameField.Font = FontsPicker.DetailsFont;
            passwordField.Font = FontsPicker.DetailsFont;
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            List<TextBox> inputs = new List<TextBox>
            {
                usernameField,
                passwordField,
                emailField
            };
            bool areInputsValid = ValidationHelper.ValidateUserInputs(inputs, profilePicture);
            if (!areInputsValid)
            {
                MessageBox.Show(InputsMessages.EmptyInputData, "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var editModel = new EditProfileInputModel()
            {
                Username = usernameField.Text.Trim(),
                Email = emailField.Text.Trim(),
                AvatarUrl = profilePicture.ImageLocation,
                Password = passwordField.Text, 
                Age = ValidationHelper.ValidateUserAge(ageField)
            };

            var (isValid, errors) = await userService.ValidateModelAsync(editModel);
            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(editModel.Username)))
                    {
                        usernameErrors.Text = error.ErrorMessage;
                        usernameErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(editModel.Password)))
                    {
                        passwordErrors.Text = error.ErrorMessage;
                        passwordErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(editModel.Email)))
                    {
                        emailErrors.Text = error.ErrorMessage;
                        emailErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(editModel.AvatarUrl)))
                    {
                        pfpErrors.Text = error.ErrorMessage;
                        pfpErrors.Visible = true;
                    }
                }
                return;
            }

            bool success = await userService.UpdateUserAsync(editModel);
            if (success)
            {
                MessageBox.Show(ProfileUpdatedSuccessfully, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Profile profileForm = new Profile(userService);
                Program.SwitchMainForm(profileForm);
            }
            else
            {
                MessageBox.Show(ProfileUpdateFailed, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void uploadImage_click(Object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = DialogFilter;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                }
                profilePicture.ImageLocation = imageLocation;

            }
            catch (Exception ex)
            {
                MessageBox.Show(EmptyOrInvalidImage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void clearInputs_click(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.Text = "";
        }
        private void input_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.ForeColor = Color.Black;
            textBox.Font = FontsPicker.BaseFont;
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = false;
            saveButton.Visible = true;

            usernameField.Enabled = true;
            passwordField.Enabled = true;

            passwordField.Text = activeUser.Password;
            passwordField.ForeColor = Color.DimGray;
            passwordField.Font = FontsPicker.DetailsFont;

            emailField.Enabled = true;
            ageField.Enabled = true;
            uploadButton.Enabled = true;

            ActiveControl = usernameField;

        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            userService.LogoutUser();
            Login loginForm = new Login(userService);
            Program.SwitchMainForm(loginForm);
        }
        private void navigationButton_Click(object sender, EventArgs e)
        {
            Index indexForm = new Index(userService);
            Program.SwitchMainForm(indexForm);
        }
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
        ProfileDeleteWarning,
        "Confirm Deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                bool isDeleted = await userService.DeleteUserAsync();

                if (isDeleted)
                {
                    MessageBox.Show(ProfileDeletionSuccessful, "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login loginForm = new Login(userService);
                    Program.SwitchMainForm(loginForm);
                }
                else
                {
                    MessageBox.Show(ProfileDeletionFailed, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
