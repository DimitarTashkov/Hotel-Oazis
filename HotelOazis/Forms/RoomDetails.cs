using HotelOazis.DTOs.Reservation;
using HotelOazis.DTOs.Room;
using HotelOazis.Extensions;
using HotelOazis.Models;
using HotelOazis.Properties;
using HotelOazis.Services.Interfaces;
using HotelOazis.Utilities;

using static HotelOazis.Common.Messages.ErrorMessages.ReservationMessages;
using static HotelOazis.Common.Messages.ResultMessages.ActionMessages;
using static HotelOazis.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace HotelOazis.Forms
{
    public partial class RoomDetails : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly IReviewService reviewService;
        private readonly IRoomService roomService;
        private readonly RoomDetailsViewModel model;
        private bool _isAuthorized;

        private User activeUser;

        public RoomDetails(IRoomService roomService, IUserService userService, RoomDetailsViewModel model)
        {
            this.roomService = roomService;
            this.userService = userService;
            this.facilityService = ServiceLocator.GetService<IFacilityService>();
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            this.model = model;
            activeUser = userService.GetLoggedInUserAsync();
            InitializeComponent();
            CustomizeUI();
        }

        private async void RoomDetails_Load(object sender, EventArgs e)
        {
            bool isAdmin = AuthorizationHelper.IsAuthorized();

            if (isAdmin)
            {
                Users.Visible = true;
                Reservations.Visible = true;
                editRoomBtn.Visible = true;
            }

            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;
            _isAuthorized = isAdmin;

            string availabilityMessage = model.IsAvailable ? IsAvailableAnswer : IsNotAvailableAnswer;
            roomNumber.Text = $"{RoomNumber} " + model.RoomNumber;
            roomType.Text = $"{RoomType} " + model.Type;
            roomPrice.Text = $"{Price} " + model.Price.ToString("F2") + " lv";
            roomAvaialability.Text = $"{AvailableMessage}: " + (model.IsAvailable ? $"{IsAvailableAnswer}" : $"{IsNotAvailableAnswer}");
            roomDescription.Text = $"{ItemDescription} " + model.Description;
            roomImage.ImageLocation = model.Picture;

            CreateIconControls();
        }
        private void CustomizeUI()
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            roomDataContainer.BackColor = Color.White;
            roomDataContainer.Padding = new Padding(10);
            roomDataContainer.BorderStyle = BorderStyle.FixedSingle;
            roomImage.SizeMode = PictureBoxSizeMode.StretchImage;
            roomImage.BorderStyle = BorderStyle.Fixed3D;

            reservateBtn.BackColor = Color.FromArgb(0, 123, 255);
            reservateBtn.ForeColor = Color.White;
            reservateBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            reservateBtn.FlatStyle = FlatStyle.Flat;
            reservateBtn.FlatAppearance.BorderSize = 0;
            reservateBtn.Cursor = Cursors.Hand;
            reservateBtn.MouseEnter += (s, e) => reservateBtn.BackColor = Color.FromArgb(0, 90, 200);
            reservateBtn.MouseLeave += (s, e) => reservateBtn.BackColor = Color.FromArgb(0, 123, 255);

            editRoomBtn.BackColor = Color.FromArgb(255, 193, 7);
            editRoomBtn.ForeColor = Color.White;
            editRoomBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            editRoomBtn.FlatStyle = FlatStyle.Flat;
            editRoomBtn.FlatAppearance.BorderSize = 0;
            editRoomBtn.Cursor = Cursors.Hand;
            editRoomBtn.MouseEnter += (s, e) => editRoomBtn.BackColor = Color.FromArgb(220, 170, 5);
            editRoomBtn.MouseLeave += (s, e) => editRoomBtn.BackColor = Color.FromArgb(255, 193, 7);
        }

        private PictureBox CreateIconPictureBox(string name, Image image, Size size, Point location)
        {
            return new PictureBox
            {
                Name = name,
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = size,
                Location = location,
                BackColor = Color.Transparent
            };
        }
        private async void reservateBtn_Click(object sender, EventArgs e)
        {
            if (model.IsAvailable)
            {
                ReservationInputModel reservationModel = new ReservationInputModel()
                {
                    UserId = userService.GetLoggedInUserAsync().Id,
                    RoomId = model.Id,
                };

                Reservate reservateForm = new Reservate(roomService, reservationModel);
                Program.SwitchMainForm(reservateForm);
            }
            MessageBox.Show(RoomIsUnavailable, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private async void editRoomBtn_Click(object sender, EventArgs e)
        {
            EditRoomInputModel editModel = new EditRoomInputModel()
            {
                Id = model.Id,
                Type = model.Type,
                Price = model.Price,
                PictureLocation = model.Picture,
                IsAvailable = model.IsAvailable,
                Description = model.Description
            };

            if (_isAuthorized)
            {
                EditRoom editRoomForm = new EditRoom(roomService, editModel);
                Program.SwitchMainForm(editRoomForm);
            }
            else
            {
                MessageBox.Show(string.Format(UpdateFailed, nameof(Rooms)), Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateIconControls()
        {
            var numberIcon = CreateIconPictureBox
                   (
                   name: $"numberIcon",
                   image: Properties.Resources.room_number,
                   size: new Size(16, 16),
                   location: new Point(roomNumber.Location.X - 20, roomNumber.Location.Y + 3)
                   );

            var typeIcon = CreateIconPictureBox
                   (
                   name: $"typeIcon",
                   image: Properties.Resources.type_icon,
                   size: new Size(16, 16),
                   location: new Point(roomType.Location.X - 20, roomType.Location.Y + 3)
                   );

            var costIcon = CreateIconPictureBox
                (
                name: $"costIcon",
                image: Properties.Resources.cost_icon,
                size: new Size(16, 16),
                location: new Point(roomPrice.Location.X - 20, roomPrice.Location.Y + 3)
                );

            var availabilityImage = model.IsAvailable ? Resources.tick_icon : Resources.cross_icon;

            var availabilityIcon = CreateIconPictureBox
                (
            name: $"availabiityIcon",
            image: availabilityImage,
                size: new Size(16, 16),
                location: new Point(roomAvaialability.Location.X - 20, roomAvaialability.Location.Y + 3)
            );
            var descriptionIcon = CreateIconPictureBox
                (
                name: $"descriptionIcon",
                image: Properties.Resources.read_more_icon,
                size: new Size(16, 16),
                location: new Point(roomDescription.Location.X - 20, roomDescription.Location.Y + 3)
                );

            roomDataContainer.Controls.Add(numberIcon);
            roomDataContainer.Controls.Add(typeIcon);
            roomDataContainer.Controls.Add(costIcon);
            roomDataContainer.Controls.Add(availabilityIcon);
            roomDataContainer.Controls.Add(descriptionIcon);
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
                    form = new Profile(userService, activeUser.Id);
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
            Profile profileForm = new Profile(userService, activeUser.Id);
            Program.SwitchMainForm(profileForm);
        }

        private void roomContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
