using Fitness.Utilities;
using HotelOazis.Common.Constants;
using HotelOazis.DTOs.Room;
using HotelOazis.DTOs.Service;
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

using static HotelOazis.Common.Messages.ResultMessages.ActionMessages;


namespace HotelOazis.Forms
{
    public partial class Services : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private static bool isAuthorized;
        public Services(IFacilityService facilityService, IUserService userService)
        {
            this.facilityService = facilityService;
            this.userService = userService;
            InitializeComponent();
        }

        private async void Services_Load(object sender, EventArgs e)
        {
            isAuthorized = await AuthorizationHelper.InitializeAuthorizationStatusAsync(userService);
            if (isAuthorized)
            {
                addService.Visible = true;
            }
            await PopulateServicesAsync();
        }
        private async Task PopulateServicesAsync()
        {
            servicesContainer.Controls.Clear();
            int index = 1;
            List<ServiceViewModel> services = await facilityService.GetServicesAsync();
            foreach (var service in services)
            {
                await CreateServiceControls(service, index);

                index++;
            }
        }
        private async Task CreateServiceControls(ServiceViewModel service, int index)
        {
            FlowLayoutPanel serviceContainer = new FlowLayoutPanel
            {
                Name = $"serviceContainer{index}"
                    ,
                Size = new Size(725, 100)
                    ,
                Margin = new Padding(8, 8, 8, 8)
                    ,
                BackColor = Color.RosyBrown
            };
            Panel serviceCredentials = new Panel
            {
                Name = $"userCredentials{index}"
                    ,
                Size = new Size(725, 100)

            };

            RoundPictureBox serviceIcon = new RoundPictureBox
            {
                Name = $"serviceIcon{index}"
                ,
                Size = new Size(50, 50)
                ,
                Image = Resources.service_icon
                ,
                Location = new Point(serviceContainer.Location.X, serviceContainer.Location.Y + 15)
                ,
                SizeMode = PictureBoxSizeMode.StretchImage
                ,
            };

            Label serviceName = new Label
            {
                Name = $"serviceName{index}"
                ,
                Text = "Name:" + " " + service.Name
                ,
                Font = FontsPicker.DetailsFont
                ,
                Location = new Point(serviceIcon.Location.X + 50, serviceIcon.Location.Y + 20)
                ,
                AutoSize = true

            };

            TextBox serviceDescription = new TextBox
            {
                Name = $"serviceDescription{index}"
                ,
                Text = "Description:" + " " + service.Description
                ,
                Font = FontsPicker.DetailsFont
                ,
                Margin = new Padding(0, 5, 0, 0)
                ,
                Location = new Point(serviceName.Size.Width + 180, serviceIcon.Location.Y + 10)
                ,
                AutoSize = true
                ,
                Size = new Size(serviceCredentials.Size.Width - 500, serviceIcon.Location.Y + 30)
                ,
                Multiline = true
                ,
                ScrollBars = ScrollBars.Vertical
                ,
                ReadOnly = true
                ,
            };
            if (isAuthorized)
            {
                var editButton = new Button
                {
                    Text = $"Edit",
                    BackColor = Color.LightGray,
                    Size = new Size(80, 29),
                    Font = FontsPicker.DetailsFont,
                    Location = new Point(serviceCredentials.Size.Width - 200, serviceIcon.Location.Y + 20)

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

                serviceCredentials.Controls.Add(editButton);

                var deleteButton = new Button
                {
                    Text = "Delete",
                    BackColor = Color.Red,
                    Size = new Size(80, 29),
                    Font = FontsPicker.DetailsFont,
                    Location = new Point(serviceCredentials.Size.Width - 100, serviceIcon.Location.Y + 20)

                };
                deleteButton.Click += async (s, e) =>
                {
                    var success = await facilityService.DeleteServiceAsync(service.Id);
                    if (success)
                    {
                        MessageBox.Show(string.Format(DeletionSuccessful, nameof(Service)), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await PopulateServicesAsync();
                    }
                    else
                    {
                        MessageBox.Show(string.Format(DeletionFailed, nameof(Service)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                serviceCredentials.Controls.Add(deleteButton);
            }
            serviceCredentials.Controls.Add(serviceIcon);
            serviceCredentials.Controls.Add(serviceName);
            serviceCredentials.Controls.Add(serviceDescription);

            serviceContainer.Controls.Add(serviceCredentials);
            servicesContainer.Controls.Add(serviceContainer);
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
    }
}
