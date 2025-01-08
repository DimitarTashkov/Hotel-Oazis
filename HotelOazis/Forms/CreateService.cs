using Fitness.Utilities;
using HotelOazis.DTOs.Room;
using HotelOazis.Models.Enumerations;
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

using static HotelOazis.Common.Messages.ErrorMessages.InputsMessages;
using static HotelOazis.Common.Messages.ResultMessages.ActionMessages;

using HotelOazis.DTOs.Service;
using HotelOazis.Models;

namespace HotelOazis.Forms
{
    public partial class CreateService : Form
    {
        private readonly IUserService userService;
        private readonly IFacilityService facilityService;
        public CreateService(IUserService userService, IFacilityService facilityService)
        {
            this.userService = userService;
            this.facilityService = facilityService;
            InitializeComponent();
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            createBtn.BackColor = Color.DarkGreen;

            List<TextBox> inputs = new List<TextBox>
            {
                nameField,
                descriptionField
            };

            bool areInputsValid = ValidationHelper.ValidateUserInputs(inputs);
            if (!areInputsValid)
            {
                MessageBox.Show(EmptyInputData, "Room Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string serviceName = nameField.Text;
            string serviceDescription = descriptionField.Text;

            ServiceInputModel serviceInputModel = new ServiceInputModel
            {
                Name = serviceName,
                Description = serviceDescription,
            };

            var (isValid, errors) = await facilityService.ValidateModelAsync(serviceInputModel);

            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(serviceInputModel.Name)))
                    {
                        nameErrors.Text = error.ErrorMessage;
                        nameErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(serviceInputModel.Description)))
                    {
                        descriptionErrors.Text = error.ErrorMessage;
                        descriptionErrors.Visible = true;
                    }
                }
                return;
            }

            bool isCreated = await facilityService.AddServiceAsync(serviceInputModel);
            if (isCreated)
            {
                MessageBox.Show(string.Format(CreatedSuccessfully, nameof(Service)), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Services servicesForm = new Services(facilityService, userService);
                Program.SwitchMainForm(servicesForm);
            }
            else
            {
                MessageBox.Show(string.Format(CreationFailed, nameof(Service)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Services servicesForm = new Services(facilityService, userService);
            Program.SwitchMainForm(servicesForm);
        }
    }
}
