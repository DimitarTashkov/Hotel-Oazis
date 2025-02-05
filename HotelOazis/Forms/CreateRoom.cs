using Fitness.Utilities;
using HotelOazis.DTOs.Room;
using HotelOazis.Extensions;
using HotelOazis.Models.Enumerations;
using HotelOazis.Services;
using HotelOazis.Services.Interfaces;
using HotelOazis.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
using HotelOazis.Models;
using Fitness.Services;

namespace HotelOazis.Forms
{
    public partial class CreateRoom : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly IReviewService reviewService;
        private readonly IRoomService roomService;

        private User activeUser;

        public CreateRoom(IRoomService roomService)
        {
            InitializeComponent();
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);

            this.roomService = roomService;
            userService = ServiceLocator.GetService<IUserService>();
            facilityService = ServiceLocator.GetService<IFacilityService>();
            reviewService = ServiceLocator.GetService<IReviewService>();
            activeUser = userService.GetLoggedInUserAsync();

            priceField.TextChanged += EventsEffects.input_TextChanged;
            priceField.Click += EventsEffects.clearInputs_click;
            descriptionField.TextChanged += EventsEffects.input_TextChanged;
            descriptionField.Click += EventsEffects.clearInputs_click;
            roomNumberField.TextChanged += EventsEffects.input_TextChanged;
            roomNumberField.Click += EventsEffects.clearInputs_click;

        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            uploadRoom.BackColor = Color.DarkGreen;

            List<TextBox> inputs = new List<TextBox>
            {
                priceField,
                roomNumberField
            };

            bool areInputsValid = ValidationHelper.ValidateUserInputs(inputs, roomPicture);
            if (!areInputsValid || roomTypes.SelectedIndex == 0)
            {
                MessageBox.Show(EmptyInputData, "Room Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isNumberValid = int.TryParse(roomNumberField.Text, out int roomNumber);
            roomNumber = isNumberValid ? roomNumber : await roomService.GenerateUniqueRoomNumber();

            if (!await roomService.IsRoomNumberUnique(roomNumber))
            {
                MessageBox.Show(RoomNumberExists, "Room Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RoomType roomType = (RoomType)roomTypes.SelectedItem;
            decimal unparsePrice = decimal.TryParse(priceField.Text, out var price) ? price : -1;
            string pictureLocation = roomPicture.ImageLocation;
            string? description = descriptionField.Text;

            RoomInputModel roomInputModel = new RoomInputModel
            {
                RoomNumber = roomNumber,
                Type = roomType,
                Price = price,
                PictureLocation = pictureLocation,
                Description = description
            };

            var (isValid, errors) = await roomService.ValidateModelAsync(roomInputModel);

            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(roomInputModel.RoomNumber)))
                    {
                        roomNumberErrors.Text = error.ErrorMessage;
                        roomNumberErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(roomInputModel.Type)))
                    {
                        typeErrors.Text = error.ErrorMessage;
                        typeErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(roomInputModel.Price)))
                    {
                        priceErrors.Text = error.ErrorMessage;
                        priceErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(roomInputModel.PictureLocation)))
                    {
                        imageErrors.Text = error.ErrorMessage;
                        imageErrors.Visible = true;
                    }
                }
                return;
            }

            bool isCreated = await roomService.AddRoomAsync(roomInputModel);
            if (isCreated)
            {
                MessageBox.Show(string.Format(CreatedSuccessfully, nameof(Room)), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Rooms roomsForm = new Rooms(roomService, userService);
                Program.SwitchMainForm(roomsForm);
            }
            else
            {
                MessageBox.Show(string.Format(CreationFailed, nameof(Room)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CreateRoom_Load(object sender, EventArgs e)
        {
            bool isAdmin = AuthorizationHelper.IsAuthorized();

            if (isAdmin)
            {
                Users.Visible = true;
                Reservations.Visible = true;
            }

            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;
            roomTypes.DataSource = Enum.GetValues(typeof(RoomType));
            roomTypes.DropDownStyle = ComboBoxStyle.DropDownList;

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
