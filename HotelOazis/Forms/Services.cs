using Fitness.Services;
using Fitness.Utilities;
using HotelOazis.Common.Constants;
using HotelOazis.DTOs.Room;
using HotelOazis.DTOs.Service;
using HotelOazis.Extensions;
using HotelOazis.Models;
using HotelOazis.Properties;
using HotelOazis.Services.Interfaces;
using HotelOazis.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static HotelOazis.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace HotelOazis.Forms
{
    public partial class Services : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly IReviewService reviewService;
        private readonly IRoomService roomService;
        private static bool isAuthorized;
        private User activeUser;

        public Services(IFacilityService facilityService, IUserService userService)
        {
            InitializeComponent();
            this.facilityService = facilityService;
            this.userService = userService;
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            this.roomService = ServiceLocator.GetService<IRoomService>();

            LoadUserDataAsync();
            ApplyStyles();
        }

        private  void LoadUserDataAsync()
        {
            activeUser =  userService.GetLoggedInUserAsync();
            roundPictureBox1.ImageLocation = activeUser?.AvatarUrl;
        }

        private void ApplyStyles()
        {
            this.BackColor = Color.FromArgb(245, 245, 245);

            addService.BackColor = Color.FromArgb(39, 174, 96);
            addService.ForeColor = Color.White;
            addService.FlatStyle = FlatStyle.Flat;
            addService.FlatAppearance.BorderSize = 0;
            addService.MouseEnter += (s, e) => addService.BackColor = Color.FromArgb(33, 154, 82);
            addService.MouseLeave += (s, e) => addService.BackColor = Color.FromArgb(39, 174, 96);
        }

        private async void Services_Load(object sender, EventArgs e)
        {
            bool isAdmin = AuthorizationHelper.IsAuthorized();
            isAuthorized = isAdmin;

            if (isAdmin)
            {
                Users.Visible = true;
                Reservations.Visible = true;
                addService.Visible = true;
            }

            await PopulateServicesAsync();
        }

        private async Task PopulateServicesAsync()
        {
            servicesContainer.Controls.Clear();
            List<ServiceViewModel> services = await facilityService.GetServicesAsync();

            int index = 0;
            foreach (var service in services)
            {
                await CreateServiceControls(service, index);
                index++;
            }
        }

        private async Task CreateServiceControls(ServiceViewModel service, int index)
        {
            Panel servicePanel = new Panel
            {
                Size = new Size(700, 100),
                BackColor = Color.White,
                Margin = new Padding(10),
                Padding = new Padding(15)
            };

            PictureBox serviceIcon = new PictureBox
            {
                Image = Resources.service_icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(50, 50),
                Location = new Point(15, 25)
            };

            Label serviceName = new Label
            {
                Text = service.Name,
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(80, 20),
                AutoSize = true
            };

            TextBox serviceDescription = new TextBox
            {
                Text = service.Description,
                Font = new Font("Segoe UI", 12),
                Location = new Point(80, 50),
                Size = new Size(500, 40),
                Multiline = true,
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                BackColor = Color.White
            };

            if (isAuthorized)
            {
                Button editButton = new Button
                {
                    Text = Edit,
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    BackColor = Color.FromArgb(149, 165, 166),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(100, 30),
                    Location = new Point(590, 20)
                };
                editButton.Click += (s, e) =>
                {
                    EditServiceInputModel model = new EditServiceInputModel
                    {
                        Id = service.Id,
                        Name = service.Name,
                        Description = service.Description
                    };
                    EditService editServiceForm = new EditService(facilityService, model);
                    Program.SwitchMainForm(editServiceForm);
                };

                Button deleteButton = new Button
                {
                    Text = Delete,
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    BackColor = Color.FromArgb(231, 76, 60),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(100, 30),
                    Location = new Point(590, 60)
                };
                deleteButton.Click += async (s, e) =>
                {
                    var success = await facilityService.DeleteServiceAsync(service.Id);
                    if (success)
                    {
                        MessageBox.Show(string.Format(DeletionSuccessful, nameof(Models.Service)), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await PopulateServicesAsync();
                    }
                    else
                    {
                        MessageBox.Show(string.Format(DeletionFailed, nameof(Models.Service)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                servicePanel.Controls.Add(editButton);
                servicePanel.Controls.Add(deleteButton);
            }

            servicePanel.Controls.Add(serviceIcon);
            servicePanel.Controls.Add(serviceName);
            servicePanel.Controls.Add(serviceDescription);

            servicesContainer.Controls.Add(servicePanel);
        }

        private void addService_Click(object sender, EventArgs e)
        {
            CreateService createServiceForm = new CreateService(userService, facilityService);
            Program.SwitchMainForm(createServiceForm);
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Index indexForm = new Index(userService);
            Program.SwitchMainForm(indexForm);
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
                case "Service":
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