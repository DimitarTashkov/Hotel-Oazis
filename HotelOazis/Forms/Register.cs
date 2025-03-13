using Fitness.Utilities;
using HotelOazis.Common.Constants;
using HotelOazis.DTOs.User;
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
using static HotelOazis.Common.Messages.ErrorMessages.UserMessages;
using static HotelOazis.Common.Messages.ErrorMessages.InputsMessages;
using static HotelOazis.Common.Constants.ValidationConstants.InputConstants;

namespace HotelOazis.Forms
{
    public partial class Register : Form
    {
        private readonly IUserService userService;

        public Register(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;

            usernameField.TextChanged += EventsEffects.input_TextChanged;
            usernameField.Click += EventsEffects.clearInputs_click;
            passwordField.TextChanged += EventsEffects.input_TextChanged;
            passwordField.Click += EventsEffects.clearInputs_click;
            emailField.TextChanged += EventsEffects.input_TextChanged;
            emailField.Click += EventsEffects.clearInputs_click;
            ageField.TextChanged += EventsEffects.input_TextChanged;
            ageField.Click += EventsEffects.clearInputs_click;

            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.BackColor = Color.FromArgb(245, 245, 245);

            // Стилове за текстови полета
            usernameField.Font = new Font("Segoe UI", 10);
            passwordField.Font = new Font("Segoe UI", 10);
            emailField.Font = new Font("Segoe UI", 10);
            ageField.Font = new Font("Segoe UI", 10);
            usernameField.BackColor = Color.White;
            passwordField.BackColor = Color.White;
            emailField.BackColor = Color.White;
            ageField.BackColor = Color.White;
            usernameField.BorderStyle = BorderStyle.FixedSingle;
            passwordField.BorderStyle = BorderStyle.FixedSingle;
            emailField.BorderStyle = BorderStyle.FixedSingle;
            ageField.BorderStyle = BorderStyle.FixedSingle;

            // Стилове за бутони
            registerButton.BackColor = Color.FromArgb(39, 174, 96);
            registerButton.ForeColor = Color.White;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            registerButton.MouseEnter += (s, e) => registerButton.BackColor = Color.FromArgb(33, 154, 82);
            registerButton.MouseLeave += (s, e) => registerButton.BackColor = Color.FromArgb(39, 174, 96);

            navigationButton.BackColor = Color.FromArgb(149, 165, 166);
            navigationButton.ForeColor = Color.White;
            navigationButton.FlatStyle = FlatStyle.Flat;
            navigationButton.FlatAppearance.BorderSize = 0;
            navigationButton.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            navigationButton.MouseEnter += (s, e) => navigationButton.BackColor = Color.FromArgb(127, 140, 141);
            navigationButton.MouseLeave += (s, e) => navigationButton.BackColor = Color.FromArgb(149, 165, 166);

           

           
        }
        private void Register_Load(object sender, EventArgs e)
        {
            usernameField.Text = "\"foulcoast\"";
            passwordField.Text = "\"mitko123\"";
            emailField.Text = "\"dimitar.tashkov@pmggd.bg\"";
            ageField.Text = "\"17\"";

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

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.DarkGreen;

            List<TextBox> inputs = new List<TextBox>
            {
                usernameField,
                passwordField,
                emailField
            };
            bool areInputsValid = ValidationHelper.ValidateUserInputs(inputs, profilePicture);
            if (!areInputsValid)
            {
                MessageBox.Show(EmptyInputData, "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = usernameField.Text.Trim();
            string password = passwordField.Text.Trim();
            string email = emailField.Text.Trim();
            string avatarUrl = profilePicture.ImageLocation;
            int age = ValidationHelper.ValidateUserAge(ageField);

            var registrationModel = new RegisterUserInputModel
            {
                Username = username,
                Password = password,
                Email = email,
                AvatarUrl = avatarUrl,
                Age = age
            };

            var (isValid, errors) = await userService.ValidateModelAsync(registrationModel);

            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(registrationModel.Username)))
                    {
                        usernameErrors.Text = error.ErrorMessage;
                        usernameErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(registrationModel.Password)))
                    {
                        passwordErrors.Text = error.ErrorMessage;
                        passwordErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(registrationModel.Email)))
                    {
                        emailErrors.Text = error.ErrorMessage;
                        emailErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(registrationModel.AvatarUrl)))
                    {
                        pfpErrorMessages.Text = error.ErrorMessage;
                        pfpErrorMessages.Visible = true;
                    }
                }
                return;
            }
            if (await userService.IsUsernameTaken(username))
            {
                MessageBox.Show(UsernameExists, "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await userService.RegisterUserAsync(registrationModel);

            MessageBox.Show(ProfileRegisteredSuccessfully, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login(userService);
            Program.SwitchMainForm(login);
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(userService);
            Program.SwitchMainForm(loginForm);
        }
    }
}