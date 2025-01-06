using HotelOazis.Common.Constants;
using HotelOazis.DTOs.Room;
using HotelOazis.Extensions;
using HotelOazis.Models.Enumerations;
using HotelOazis.Services;
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

using static HotelOazis.Common.Messages.ResultMessages.RoomMessages;
using static HotelOazis.Common.Messages.ErrorMessages.InputsMessages;
using static HotelOazis.Common.Constants.ValidationConstants.InputConstants;
using Fitness.Utilities;



namespace HotelOazis.Forms
{
    public partial class EditRoom : Form
    {
        private readonly IRoomService roomService;
        private readonly IUserService userService;
        private readonly EditRoomInputModel model;
        public EditRoom(IRoomService roomService, EditRoomInputModel model)
        {
            ActiveControl = priceLabel;
            this.roomService = roomService;
            this.model = model;
            this.userService = ServiceLocator.GetService<IUserService>();
            InitializeComponent();
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);

            priceField.TextChanged += EventsEffects.input_TextChanged;
            priceField.Click += EventsEffects.clearInputs_click;
            descriptionField.TextChanged += EventsEffects.input_TextChanged;
            descriptionField.Click += EventsEffects.clearInputs_click;

        }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            roomTypes.DataSource = Enum.GetValues(typeof(RoomType));

            roomTypes.SelectedItem = model.Type;
            priceField.Text = model.Price.ToString();
            roomPicture.ImageLocation = model.PictureLocation;
            descriptionField.Text = model.Description;
            statusBox.SelectedIndex = model.IsAvailable ? 0 : 1;

            roomTypes.ForeColor = Color.DimGray;
            priceField.ForeColor = Color.DimGray;
            descriptionField.ForeColor = Color.DimGray;
            statusBox.ForeColor = Color.DimGray;

            roomTypes.Font = FontsPicker.DetailsFont;
            priceField.Font = FontsPicker.DetailsFont;
            descriptionField.Font = FontsPicker.DetailsFont;
            statusBox.Font = FontsPicker.DetailsFont;

            roomTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            statusBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private async void editButton_Click(object sender, EventArgs e)
        {
            List<TextBox> inputs = new List<TextBox>
            {
                priceField,
                descriptionField,
            };
            bool areInputsValid = ValidationHelper.ValidateUserInputs(inputs, roomPicture);
            if (!areInputsValid ||
                roomTypes.SelectedItem == null || statusBox.SelectedItem == null)
            {
                MessageBox.Show(EmptyInputData, "Room Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal unparsePrice = decimal.TryParse(priceField.Text, out var price) ? price : 0;

            var editModel = new EditRoomInputModel()
            {
                Id = model.Id,
                Type = (RoomType)roomTypes.SelectedItem,
                Price = price,
                PictureLocation = roomPicture.ImageLocation,
                Description = descriptionField.Text,
                IsAvailable = statusBox.SelectedIndex == 0 ? true : false
            };

            var (isValid, errors) = await userService.ValidateModelAsync(editModel);
            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(editModel.Type)))
                    {
                        typeErrors.Text = error.ErrorMessage;
                        typeErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(editModel.Price)))
                    {
                        priceErrors.Text = error.ErrorMessage;
                        priceErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(editModel.PictureLocation)))
                    {
                        imageErrors.Text = error.ErrorMessage;
                        imageErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(editModel.IsAvailable)))
                    {
                        statusErrors.Text = error.ErrorMessage;
                        statusErrors.Visible = true;
                    }
                }
                return;
            }

            bool success = await roomService.EditRoomAsync(editModel);
            if (success)
            {
                MessageBox.Show(RoomUpdatedSuccessfully, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EditRoom editForm = new EditRoom(roomService, editModel);
                Program.SwitchMainForm(editForm);
            }
            else
            {
                MessageBox.Show(RoomUpdateFailed, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Rooms roomsForm = new Rooms(roomService, userService);
            Program.SwitchMainForm(roomsForm);
        }
        private void uploadImage_click(Object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = DialogFilter;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                }
                roomPicture.ImageLocation = imageLocation;

            }
            catch (Exception ex)
            {
                MessageBox.Show(EmptyOrInvalidImage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
