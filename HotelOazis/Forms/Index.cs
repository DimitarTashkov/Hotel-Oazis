using HotelOazis.Common.Constants;
using HotelOazis.Models;
using HotelOazis.Services.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;

namespace HotelOazis.Forms
{
    public partial class Index : Form
    {
        private readonly IUserService userService;
        private User activeUser;
        public Index(IUserService userService)
        {
            this.userService = userService;
            activeUser = userService.GetLoggedInUserAsync();
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;

        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(userService);
            Program.SwitchMainForm(profileForm);
        }
        private void buttons_Hover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.ButtonHighlight;
        }
        private void buttons_Leave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.ButtonFace;
        }
        private void roomsButton_Click(object sender, EventArgs e)
        {
            Rooms roomsForm = new Rooms();
            Program.SwitchMainForm(roomsForm);
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            Services servicesForm = new Services();
            Program.SwitchMainForm(servicesForm);
        }
        private void menu_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            string formName = item.Name;
            Form form = new Form();

            switch (formName)
            {
                case "Rooms":
                    form = new Rooms();
                    break;
                case "Services":
                    form = new Services();
                    break;
                case "Reviews":
                    form = new Reviews();
                    break;
                case "Profile":
                    form = new Profile(activeUser);
                    break;
                case "Comments":
                    form = new Comments();
                    break;
                case "Orders":
                    form = new Orders(activeUser);
                    break;
                default:
                    form = new Index();
                    break;
            }
            Program.SwitchMainForm(form);
        }
    }
}
