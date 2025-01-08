using Fitness.Utilities;
using HotelOazis.Common.Constants;
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
            //TODO: Add panel to enable positioning
            //TODO: Add edit and delete buttons
            FlowLayoutPanel serviceContainer = new FlowLayoutPanel
            {
                Name = $"serviceContainer{index}"
                    ,
                Size = new Size(725, 80)
                    ,
                Margin = new Padding(8, 8, 8, 8)
                    ,
                BackColor = Color.RosyBrown
            };

            RoundPictureBox serviceIcon = new RoundPictureBox
            {
                Name = $"serviceIcon{index}"
                ,
                Size = new Size(50, 50)
                ,
                Image = Resources.service_icon
                ,
                Location = new Point(serviceContainer.Location.X + 20, serviceContainer.Location.Y + 15)
                ,
                SizeMode = PictureBoxSizeMode.StretchImage

            };

            Label serviceName = new Label
            {
                Name = $"serviceName{index}"
                ,
                Text = service.Name
                ,
                Font = FontsPicker.DetailsFont
                ,
                Location = new Point(serviceIcon.Location.X + 50, serviceIcon.Location.Y + 25)

            };

            Label serviceDescription = new Label
            {
                Name = $"serviceDescription{index}"
                ,
                Text = service.Description
                ,
                Font = FontsPicker.DetailsFont
                ,
                Margin = new Padding(0, 5, 0, 0)
                ,
                Location = new Point(serviceIcon.Location.X + 80, serviceIcon.Location.Y)
                ,
                AutoSize = true
                ,
            };
            serviceContainer.Controls.Add(serviceIcon);
            serviceContainer.Controls.Add(serviceName);
            serviceContainer.Controls.Add(serviceDescription);

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
