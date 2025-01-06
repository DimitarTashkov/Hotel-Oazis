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

namespace HotelOazis.Forms
{
    public partial class Profile : Form
    {
        private User activeUser;
        private readonly IUserService userService;


        public Profile(IUserService userService)
        {
            ActiveControl = usernameLabel;

            InitializeComponent();
            activeUser = userService.GetLoggedInUserAsync();
            this.userService = userService;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);

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
    }
}
