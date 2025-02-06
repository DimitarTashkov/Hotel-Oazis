using Fitness.Services;
using HotelOazis.Common.Constants;
using HotelOazis.DTOs.Reservation;
using HotelOazis.DTOs.Room;
using HotelOazis.Extensions;
using HotelOazis.Models;
using HotelOazis.Properties;
using HotelOazis.Services;
using HotelOazis.Services.Interfaces;
using HotelOazis.Utilities;
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

using static HotelOazis.Common.Messages.ErrorMessages.ReservationMessages;
using static HotelOazis.Common.Messages.ResultMessages.ActionMessages;


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
            activeUser = userService.GetLoggedInUserAsync();
            this.roomService = roomService;
            this.userService = userService;
            this.facilityService = ServiceLocator.GetService<IFacilityService>();
            this.reviewService = ServiceLocator.GetService<IReviewService>();
        }
        private async Task CreateRoomButtons(RoomViewModel room, Panel container, User activeUser)
        {
            var readMoreButton = new Button
            {
                Text = "Read more",
                BackColor = Color.LightPink,
                Size = new Size(112, 29),
                Location = new Point(0, 215),
                Font = FontsPicker.DetailsFont,
            };
            readMoreButton.Click += (s, e) =>
            {
                RoomDetailsViewModel model = new RoomDetailsViewModel
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
            container.Controls.Add(readMoreButton);

            var reserveButton = new Button
            {
                Text = "Reserve",
                BackColor = Color.LightGreen,
                Size = new Size(112, 29),
                Location = new Point(112, 215),
                Font = FontsPicker.DetailsFont,

            };
            reserveButton.Click += async (s, e) =>
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
                    MessageBox.Show(RoomIsUnavailable, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            container.Controls.Add(reserveButton);

            if (_isAuthorized)
            {
                var editButton = new Button
                {
                    Text = "Edit",
                    BackColor = Color.LightGray,
                    Size = new Size(112, 29),
                    Location = new Point(0, 244),
                    Font = FontsPicker.DetailsFont,

                };
                editButton.Click += (s, e) =>
                {
                    EditRoomInputModel model = new EditRoomInputModel
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
                container.Controls.Add(editButton);

                var deleteButton = new Button
                {
                    Text = "Delete",
                    BackColor = Color.Red,
                    Size = new Size(112, 29),
                    Location = new Point(112, 244),
                    Font = FontsPicker.DetailsFont,

                };
                deleteButton.Click += async (s, e) =>
                {
                    var success = await roomService.DeleteRoomAsync(room.Id);
                    if (success)
                    {
                        MessageBox.Show(string.Format(DeletionSuccessful, nameof(Models.Room)), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await PopulateRoomsPanelAsync(container, activeUser);
                    }
                    else
                    {
                        MessageBox.Show(string.Format(DeletionFailed, nameof(Models.Room)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                container.Controls.Add(deleteButton);
            }
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
                    Size = new Size(225, 272),
                    BackColor = Color.NavajoWhite
                };
                var numberLabel = CreateLabel($"numberLabel{index}", $"Room: {room.RoomNumber.ToString()}", FontsPicker.BaseFont, new Point(80, 151));
                var typeLabel = CreateLabel($"typeLabel{index}", $"Type: { room.Type.ToString()}", FontsPicker.BaseFont, new Point(60, 166));
                var priceLabel = CreateLabel($"priceLabel{index}", $"{room.Price:f2} lv", FontsPicker.DetailsFont, new Point(30, 190));
                var availabilityLabel = CreateLabel($"availabilityLabel{index}","Available:", FontsPicker.DetailsFont, new Point(110, 190));

                PictureBox image = new PictureBox()
                {
                    Name = $"pictureBox{index}"
                     ,
                    ImageLocation = room.PictureLocation,
                    Size = new Size(151, 151),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(container.Location.X + 37, container.Location.Y),
                };
                var numberIcon = CreateIconPictureBox
                   (
                   name: $"numberIcon{index}",
                   image: Properties.Resources.room_number,
                   size: new Size(16, 16),
                   location: new Point(container.Location.X + 60, image.Size.Height)
                   );

                var typeIcon = CreateIconPictureBox
                    (
                    name: $"infoIcon{index}",
                    image: Properties.Resources.type_icon, 
                    size: new Size(16, 16), 
                    location: new Point(typeLabel.Location.X - 20, typeLabel.Location.Y + 3) 
                    );

                var costIcon = CreateIconPictureBox
                    (
                    name: $"costIcon{index}",
                    image: Properties.Resources.cost_icon,
                    size: new Size(16, 16),
                    location: new Point(priceLabel.Location.X - 20, priceLabel.Location.Y + 3)
                    );
                var availabilityImage = room.IsAvailable ? Resources.tick_icon : Resources.cross_icon;

                var availabilityIcon = CreateIconPictureBox
                    (
                    name: $"availabiityIcon{index}",
                    image: availabilityImage,
                    size: new Size(16, 16),
                    location: new Point(container.Size.Width - 30, availabilityLabel.Location.Y + 3)
                    );

                container.Controls.Add(numberIcon);
                container.Controls.Add(typeIcon);
                container.Controls.Add(costIcon);
                container.Controls.Add(availabilityIcon);
                container.Controls.Add(numberLabel);
                container.Controls.Add(typeLabel);
                container.Controls.Add(priceLabel);
                container.Controls.Add(availabilityLabel);
                container.Controls.Add(image);

                // Add buttons
                CreateRoomButtons(room, container, activeUser);

                mainContainer.Controls.Add(container);
                index++;
            }
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

        private async void Rooms_Load(object sender, EventArgs e)
        {
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
