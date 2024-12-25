using HotelOazis.Common.Constants;
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
        public Login()
        {
            InitializeComponent();
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

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
            Register registerForm = new Register();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
