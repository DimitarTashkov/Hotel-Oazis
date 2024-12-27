using HotelOazis.Common.Constants;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);

        }

        private void Register_Load(object sender, EventArgs e)
        {
            usernameField.Text = "\"foulcoast\"";
            passwordField.Text = "\"mitko123\"";
            emailField.Text = "\"dimitar.tashkov@pmggd.bg\"";
            ageField.Text = "\"17\"";

            emailField.ForeColor = Color.DimGray;
            ageField.ForeColor = Color.DimGray;
            usernameField.ForeColor = Color.DimGray;
            passwordField.ForeColor = Color.DimGray;
            disclaimer.ForeColor = Color.DimGray;


            emailField.Font = FontsPicker.DetailsFont;
            ageField.Font = FontsPicker.DetailsFont;
            usernameField.Font = FontsPicker.DetailsFont;
            passwordField.Font = FontsPicker.DetailsFont;
            disclaimer.Font = FontsPicker.DetailsFont;
        }
    }
}
