using Fitness.Services;
using Fitness.Utilities;
using HotelOazis.Common.Constants;
using HotelOazis.Extensions;
using HotelOazis.Models;
using HotelOazis.Services;
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

namespace HotelOazis.Forms
{
    public partial class Users : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly IReviewService reviewService;
        private readonly IRoomService roomService;
        private User activeUser;
        private bool _isAuthorized;
        public Users(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
            this.facilityService = ServiceLocator.GetService<IFacilityService>();
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            this.roomService = ServiceLocator.GetService<IRoomService>();
            activeUser = userService.GetLoggedInUserAsync();
        }
        private async void Users_Load(object sender, EventArgs e)
        {
            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;

            User loggedInUser = userService.GetLoggedInUserAsync();
            var users = await userService.GetUsersAsync();
            int index = 0;

            foreach (var user in users)
            {
                FlowLayoutPanel userContainer = new FlowLayoutPanel
                {
                    Name = $"userContainer{index}",
                    Size = new Size(725, 120),
                    Margin = new Padding(8),
                    BackColor = Color.RosyBrown
                };

                RoundPictureBox userAvatar = new RoundPictureBox
                {
                    Name = $"userAvatar{index}",
                    Size = new Size(50, 50),
                    ImageLocation = user.AvatarUrl,
                    Margin = new Padding(0, 5, 30, 0),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                Label username = new Label
                {
                    Name = $"username{index}",
                    Text = user.Username,
                    Font = FontsPicker.DetailsFont,
                    Margin = new Padding(25, 5, 25, 0)
                };

                Label password = new Label
                {
                    Name = $"password{index}",
                    Font = FontsPicker.DetailsFont,
                    Margin = new Padding(0, 5, 20, 0),
                    Text = new string('*', 10) 
                };

                Label email = new Label
                {
                    Name = $"email{index}",
                    Text = user.Email,
                    MaximumSize = new Size(100, 0),
                    AutoSize = true,
                    Font = FontsPicker.DetailsFont,
                    Margin = new Padding(0, 5, 20, 0)
                };

                Label age = new Label
                {
                    Name = $"age{index}",
                    Text = user.Age.ToString(),
                    Font = FontsPicker.DetailsFont,
                    Margin = new Padding(0, 5, 0, 0)
                };

                _isAuthorized = await userService.IsUserAdminAsync(user.Id);
                ComboBox isAdminBox = new ComboBox
                {
                    Name = $"isAuthorized{index}",
                    Font = FontsPicker.DetailsFont,
                    Margin = new Padding(0, 5, 20, 0),
                };

                isAdminBox.Items.AddRange(new object[] { "True", "False" });
                isAdminBox.SelectedIndex = _isAuthorized ? 0 : 1;

                isAdminBox.SelectedIndexChanged += async (s, e) =>
                {
                    bool isAdmin = isAdminBox.SelectedItem.ToString() == "True";

                    if (isAdmin)
                        await userService.MakeUserAdminAsync(user.Id);
                    else
                        await userService.RemoveAdminRoleAsync(user.Id);
                };

                Button edit = new Button
                {
                    Name = $"edit{index}",
                    Text = "Edit",
                    Font = FontsPicker.DetailsFont,
                    BackColor = Color.LightGray,
                    Margin = new Padding(330, 0, 0, 0)
                };

                edit.Click += (s, e) =>
                {
                    Profile profileForm = new Profile(userService);
                    Program.SwitchMainForm(profileForm);
                };

                Button delete = new Button
                {
                    Name = $"delete{index}",
                    Text = "Delete",
                    Font = FontsPicker.DetailsFont,
                    BackColor = Color.Red,
                    Margin = new Padding(330, 10, 0, 0)
                };

                delete.Click += async (s, e) =>
                {
                    var success = await userService.DeleteUserAsync();
                    if (success)
                    {
                        usersContainer.Controls.Remove(userContainer);
                    }
                };

                userContainer.Controls.Add(username);
                userContainer.Controls.Add(password);
                userContainer.Controls.Add(email);
                userContainer.Controls.Add(age);
                userContainer.Controls.Add(userAvatar);
                userContainer.Controls.Add(isAdminBox);
                userContainer.Controls.Add(edit);
                userContainer.Controls.Add(delete);

                usersContainer.Controls.Add(userContainer);

                index++;
            }
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
