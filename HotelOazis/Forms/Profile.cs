using HotelOazis.Common.Constants;
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

namespace HotelOazis.Forms
{
    public partial class Profile : Form
    {
        private User activeUser;
        public Profile(IUserService userService)
        {
            InitializeComponent();
            activeUser = userService.GetLoggedInUserAsync();
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
    }
}
