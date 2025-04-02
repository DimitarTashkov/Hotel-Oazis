using HotelOazis.DTOs.Reservation;
using HotelOazis.DTOs.Room;
using HotelOazis.Extensions;
using HotelOazis.Models;
using HotelOazis.Services.Interfaces;
using HotelOazis.Utilities;

using static HotelOazis.Common.Messages.ErrorMessages.ReservationMessages;
using static HotelOazis.Utilities.DynamicContentTranslator.EntitiesTranslation;


namespace HotelOazis.Forms
{
    public partial class Rooms : Form
    {
        private readonly IRoomService roomService;
        private readonly IUserService userService;
        private readonly IFacilityService facilityService;
        private readonly IReviewService reviewService;
        private static bool _isAuthorized;
        private User activeUser;

        public Rooms(IRoomService roomService, IUserService userService)
        {
            InitializeComponent();
            this.roomService = roomService;
            this.userService = userService;
            this.facilityService = ServiceLocator.GetService<IFacilityService>();
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            activeUser = userService.GetLoggedInUserAsync();
        }
        
        private async Task PopulateRoomsPanelAsync(Panel mainContainer, User activeUser)
        {
            var rooms = await roomService.GetRoomsAsync();
            mainContainer.Controls.Clear();

            int index = 1;
            foreach (var room in rooms)
            {
                var container = new Panel
                {
                    Name = $"container{index}",
                    Size = new Size(230, 360),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                };

                // Снимка на стаята
                PictureBox image = new PictureBox()
                {
                    Name = $"pictureBox{index}",
                    ImageLocation = room.PictureLocation,
                    Size = new Size(200, 140),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                };

                // Заглавие
                Label lblTitle = CreateLabel($"lblTitle{index}", $"{RoomNumber} {room.RoomNumber} - {room.Type}", new Font("Segoe UI", 11, FontStyle.Bold), new Point(10, 150));

                // Цена
                Label lblPrice = CreateLabel($"lblPrice{index}", $"{Price} {room.Price:f2} лв.", new Font("Segoe UI", 10, FontStyle.Bold), new Point(10, 180));
                lblPrice.ForeColor = Color.DarkGreen;

                // Наличност
                Label lblAvailability = CreateLabel($"lblAvailability{index}", room.IsAvailable ? $"{AvailableMessage}" : $"{UnavailableMessage}", new Font("Segoe UI", 10), new Point(10, 200));
                lblAvailability.ForeColor = room.IsAvailable ? Color.Green : Color.Red;

                // Бутон "Резервирай"
                Button btnReserve = CreateStyledButton(Reserve, Color.FromArgb(76, 175, 80), Color.White, new Size(100, 30), new Point(10, 240));
                btnReserve.Click += async (s, e) =>
                {
                    if (room.IsAvailable)
                    {
                        ReservationInputModel reservationModel = new ReservationInputModel()
                        {
                            UserId = activeUser.Id,
                            RoomId = room.Id,
                        };
                        Reservate reservateForm = new Reservate(roomService, reservationModel);
                        Program.SwitchMainForm(reservateForm);
                    }
                    else
                    {
                        MessageBox.Show(RoomIsUnavailable, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                // Бутон "Прочети повече"
                Button btnReadMore = CreateStyledButton(ReadMore, Color.LightGray, Color.Black, new Size(100, 30), new Point(120, 240));
                btnReadMore.Click += (s, e) =>
                {
                    RoomDetailsViewModel model = new RoomDetailsViewModel()
                    {
                        Id = room.Id,
                        RoomNumber = room.RoomNumber,
                        Type = room.Type,
                        Price = room.Price,
                        IsAvailable = room.IsAvailable,
                        Picture = room.PictureLocation,
                        Description = room.Description,
                    };
                    var readMoreForm = new RoomDetails(roomService, userService, model);
                    Program.SwitchMainForm(readMoreForm);
                };

                // Бутон "Редактирай" (само за администратори)
                Button btnEdit = CreateStyledButton(Edit, Color.Orange, Color.White, new Size(100, 30), new Point(10, 280));
                btnEdit.Click += (s, e) =>
                {
                    EditRoomInputModel model = new EditRoomInputModel()
                    {
                        Id = room.Id,
                        RoomNumber = room.RoomNumber,
                        Type = room.Type,
                        IsAvailable = room.IsAvailable,
                        PictureLocation = room.PictureLocation,
                        Description = room.Description,
                        Price = room.Price,
                    };
                    var editForm = new EditRoom(roomService, model);
                    Program.SwitchMainForm(editForm);
                };

                // Бутон "Изтрий" (само за администратори)
                Button btnDelete = CreateStyledButton(Delete, Color.Red, Color.White, new Size(100, 30), new Point(120, 280));
                btnDelete.Click += async (s, e) =>
                {
                    var success = await roomService.DeleteRoomAsync(room.Id);
                    if (success)
                    {
                        MessageBox.Show(string.Format(DeletionSuccessful,nameof(Room)), Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await PopulateRoomsPanelAsync(mainContainer, activeUser);
                    }
                    else
                    {
                        MessageBox.Show(string.Format(DeletionFailed, nameof(Room)), Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                // Добавяне на елементи в панела
                container.Controls.Add(image);
                container.Controls.Add(lblTitle);
                container.Controls.Add(lblPrice);
                container.Controls.Add(lblAvailability);
                container.Controls.Add(btnReserve);
                container.Controls.Add(btnReadMore);

                if (_isAuthorized)
                {
                    container.Controls.Add(btnEdit);
                    container.Controls.Add(btnDelete);
                }

                // Добавяне на панела към главния контейнер
                mainContainer.Controls.Add(container);
                index++;
            }
        }

        private Button CreateStyledButton(string text, Color backColor, Color textColor, Size size, Point location)
        {
            return new Button
            {
                Text = text,
                BackColor = backColor,
                ForeColor = textColor,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = size,
                Location = location,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                FlatAppearance = { BorderSize = 0 }
            };
        }


        private Label CreateLabel(string name, string text, Font font, Point location)
        {
            return new Label
            {
                Name = name,
                Text = text,
                Font = font,
                Location = location,
                AutoSize = true,

            };
        }

        private async void Rooms_Load(object sender, EventArgs e)
        {
            addRoom.FlatStyle = FlatStyle.Flat;
            addRoom.FlatAppearance.BorderSize = 0;
            addRoom.BackColor = Color.FromArgb(76, 175, 80); // Зелен фон
            addRoom.ForeColor = Color.White; // Бял текст
            addRoom.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            addRoom.MouseEnter += (s, e) => addRoom.BackColor = Color.FromArgb(56, 142, 60);
            addRoom.MouseLeave += (s, e) => addRoom.BackColor = Color.FromArgb(76, 175, 80);
            bool isAdmin = AuthorizationHelper.IsAuthorized();

            if (isAdmin)
            {
                addRoom.Visible = true;
                Users.Visible = true;
                Reservations.Visible = true;
            }

            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;

            _isAuthorized = isAdmin;

            var loggedInUser = userService.GetLoggedInUserAsync();

            await PopulateRoomsPanelAsync(mainContainer, loggedInUser);
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Index indexForm = new Index(userService);
            Program.SwitchMainForm(indexForm);
        }

        private void addSupplement_Click(object sender, EventArgs e)
        {
            CreateRoom createRoomForm = new CreateRoom(roomService);
            Program.SwitchMainForm(createRoomForm);
        }
        private void menu_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            string formName = item.Name;
            Form form = new Form();

            switch (formName)
            {
                case "Room":
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
    }
}
