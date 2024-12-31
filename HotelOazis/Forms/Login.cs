﻿using Fitness.Utilities;
using HotelOazis.Common.Constants;
using HotelOazis.Common.Messages;
using HotelOazis.DTOs.User;
using HotelOazis.Models.DbConfiguration;
using HotelOazis.Services.Interfaces;
using HotelOazis.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelOazis.Common.Messages.ErrorMessages;

namespace HotelOazis.Forms
{
    public partial class Login : Form
    {
        private readonly IUserService userService;
        public Login(IUserService userService)
        {
            this.userService = userService;
            InitializeComponent();
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);
            usernameField.TextChanged += EventsEffects.input_TextChanged;
            usernameField.Click += EventsEffects.clearInputs_click;
            passwordField.TextChanged += EventsEffects.input_TextChanged;
            passwordField.Click += EventsEffects.clearInputs_click;

        }
        private void register_hover(object sender, EventArgs e)
        {
            register.ForeColor = Color.Indigo;
        }

        private void register_leave(object sender, EventArgs e)
        {
            register.ForeColor = Color.Blue;
        }
        private void register_Click(object sender, EventArgs e)
        {
            register.ForeColor = Color.BlueViolet;
            Register registerForm = new Register(userService);
            Program.SwitchMainForm(registerForm);
        }

        private void login_hover(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.DeepSkyBlue;
        }

        private void login_leave(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.SkyBlue;
            loginBtn.ForeColor = Color.Black;
        }
        private async void login_Click(object sender, EventArgs e)
        {
            List<TextBox> inputs = new List<TextBox>()
            {
                usernameField
                ,passwordField
            };

            bool areInputValid = ValidationHelper.ValidateUserInputs(inputs);
            if (!areInputValid)
            {
                MessageBox.Show(InputsMessages.EmptyInputData, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            string username = usernameField.Text.Trim();
            string password = passwordField.Text.Trim();

            var loginModel = new LoginUserInputModel
            {
                Username = username,
                Password = password
            };

            var (isValid, errors) = await userService.ValidateModelAsync(loginModel);

            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(loginModel.Username)))
                    {
                        usernameError.Text = error.ErrorMessage;
                        usernameError.Visible = true;
                    }

                    if (error.MemberNames.Contains(nameof(loginModel.Password)))
                    {
                        passwordError.Text = error.ErrorMessage;
                        passwordError.Visible = true;
                    }
                }
                return;
            }

            bool isAuthenticated = await userService.AuthenticateUserAsync(username, password);

            if (isAuthenticated)
            {
                Index indexForm = new Index(userService);
                Program.SwitchMainForm(indexForm);
            }
            else
            {
                MessageBox.Show(UserMessages.InvalidUserCredentials, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.ForeColor = Color.Black;
            textBox.Font = FontsPicker.BaseFont;
        }


    }
}
