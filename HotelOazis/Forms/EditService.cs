using Fitness.Utilities;
using HotelOazis.DTOs.Room;
using HotelOazis.DTOs.Service;
using HotelOazis.Extensions;
using HotelOazis.Models.Enumerations;
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

using static HotelOazis.Common.Messages.ErrorMessages.InputsMessages;
using static HotelOazis.Common.Messages.ResultMessages.ActionMessages;
using HotelOazis.Common.Constants;

namespace HotelOazis.Forms
{
    public partial class EditService : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly EditServiceInputModel model;
        public EditService(IFacilityService facilityService, EditServiceInputModel model)
        {
            this.facilityService = facilityService;
            this.model = model;
            this.userService = ServiceLocator.GetService<IUserService>();
            InitializeComponent();

            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);

            nameField.TextChanged += EventsEffects.input_TextChanged;
            nameField.Click += EventsEffects.clearInputs_click;
            descriptionField.TextChanged += EventsEffects.input_TextChanged;
            descriptionField.Click += EventsEffects.clearInputs_click;
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Services servicesForm = new Services(facilityService, userService);
            Program.SwitchMainForm(servicesForm);
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {
            List<TextBox> inputs = new List<TextBox>
            {
                nameField,
                descriptionField,
            };
            bool areInputsValid = ValidationHelper.ValidateUserInputs(inputs);
            if (!areInputsValid)
            {
                MessageBox.Show(EmptyInputData, "Room Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var editModel = new EditServiceInputModel()
            {
                Id = model.Id,
                Name = nameField.Text,
                Description = descriptionField.Text
            };

            var (isValid, errors) = await userService.ValidateModelAsync(editModel);
            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(editModel.Name)))
                    {
                        nameErrors.Text = error.ErrorMessage;
                        nameErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(editModel.Description)))
                    {
                        descriptionErrors.Text = error.ErrorMessage;
                        descriptionErrors.Visible = true;
                    }
                }
                return;
            }

            bool success = await facilityService.EditServiceAsync(editModel);
            if (success)
            {
                MessageBox.Show(string.Format(UpdatedSuccessfully, nameof(Service)), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EditService editServiceForm = new EditService(facilityService, editModel);
                Program.SwitchMainForm(editServiceForm);
            }
            else
            {
                MessageBox.Show(string.Format(UpdateFailed, nameof(Service)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            nameField.Text = model.Name;
            descriptionField.Text = model.Description;

            nameField.ForeColor = Color.DimGray;
            descriptionField.ForeColor = Color.DimGray;

            nameField.Font = FontsPicker.DetailsFont;
            descriptionField.Font = FontsPicker.DetailsFont;
        }
    }
}
