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

using static HotelOazis.Common.Messages.ResultMessages.ActionMessages;
using static HotelOazis.Common.Messages.ErrorMessages.InputsMessages;
using static HotelOazis.Common.Messages.ErrorMessages.RoomMessages;
using static HotelOazis.Common.Constants.ValidationConstants.InputConstants;
using static HotelOazis.Utilities.DynamicContentTranslator.RoomsTranslator;
using Fitness.Utilities;
using HotelOazis.Models;
using Fitness.Services;



namespace HotelOazis.Forms
{
    public partial class EditRoom : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly IReviewService reviewService;
        private readonly IRoomService roomService;
        private readonly EditRoomInputModel model;
        private User activeUser;
        public EditRoom(IRoomService roomService, EditRoomInputModel model)
        {
            ActiveControl = priceLabel;
            this.model = model;
            this.roomService = roomService;
            this.userService = ServiceLocator.GetService<IUserService>();
            this.facilityService = ServiceLocator.GetService<IFacilityService>();
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            this.activeUser = userService.GetLoggedInUserAsync();

            InitializeComponent();

            priceField.TextChanged += EventsEffects.input_TextChanged;
            priceField.Click += EventsEffects.clearInputs_click;
            descriptionField.TextChanged += EventsEffects.input_TextChanged;
            descriptionField.Click += EventsEffects.clearInputs_click;
            roomNumberField.TextChanged += EventsEffects.input_TextChanged;
            roomNumberField.Click += EventsEffects.clearInputs_click;

        }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            bool isAdmin = AuthorizationHelper.IsAuthorized();

            if (isAdmin)
            {
                Users.Visible = true;
                Reservations.Visible = true;
            }

            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;

            roomTypes.DataSource = Enum.GetValues(typeof(RoomType));

            roomTypes.SelectedItem = model.Type;
            roomNumberField.Text = model.RoomNumber.ToString();
            priceField.Text = model.Price.ToString();
            roomPicture.ImageLocation = model.PictureLocation;
            descriptionField.Text = model.Description;
            statusBox.SelectedIndex = model.IsAvailable ? 0 : 1;

            roomTypes.ForeColor = Color.DimGray;
            priceField.ForeColor = Color.DimGray;
            descriptionField.ForeColor = Color.DimGray;
            statusBox.ForeColor = Color.DimGray;
            roomNumberField.ForeColor = Color.DimGray;

            roomTypes.Font = FontsPicker.DetailsFont;
            priceField.Font = FontsPicker.DetailsFont;
            descriptionField.Font = FontsPicker.DetailsFont;
            statusBox.Font = FontsPicker.DetailsFont;
            roomNumberField.Font = FontsPicker.DetailsFont;

            roomTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            statusBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private async void editButton_Click(object sender, EventArgs e)
        {
            List<TextBox> inputs = new List<TextBox>
            {
                priceField,
                descriptionField,
                roomNumberField
            };
            bool areInputsValid = ValidationHelper.ValidateUserInputs(inputs, roomPicture);
            if (!areInputsValid ||
                roomTypes.SelectedItem == null || statusBox.SelectedItem == null)
            {
                MessageBox.Show(EmptyInputData, EditFailed, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isNumberValid = int.TryParse(roomNumberField.Text, out int roomNumber);
            roomNumber = isNumberValid ? roomNumber : await roomService.GenerateUniqueRoomNumber();

            if (!await roomService.IsRoomNumberUnique(roomNumber))
            {
                MessageBox.Show(RoomNumberExists, EditFailed, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal unparsePrice = decimal.TryParse(priceField.Text, out var price) ? price : 0;

            var editModel = new EditRoomInputModel()
            {
                Id = model.Id,
                RoomNumber = roomNumber,
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
                    if (error.MemberNames.Contains(nameof(editModel.RoomNumber)))
                    {
                        roomNumberErrors.Text = error.ErrorMessage;
                        roomNumberErrors.Visible = true;
                    }
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
                MessageBox.Show(string.Format(UpdatedSuccessfully, nameof(Rooms)), Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                EditRoom editForm = new EditRoom(roomService, editModel);
                Program.SwitchMainForm(editForm);
            }
            else
            {
                MessageBox.Show(string.Format(UpdateFailed, nameof(Rooms)), Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(EmptyOrInvalidImage, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
