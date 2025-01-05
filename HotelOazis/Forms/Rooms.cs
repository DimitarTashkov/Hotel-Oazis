using HotelOazis.Common.Constants;
using HotelOazis.DTOs.Room;
using HotelOazis.Models;
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

using static HotelOazis.Common.Messages.ErrorMessages.ReservationMessages;
using static HotelOazis.Common.Messages.ResultMessages.RoomMessages;


namespace HotelOazis.Forms
{
    public partial class Rooms : Form
    {
        private readonly IRoomService roomService;
        private readonly IUserService userService;
        private static bool _isAuthorized;

        public Rooms(IRoomService roomService, IUserService userService)
        {
            InitializeComponent();
            this.roomService = roomService;
            this.userService = userService;
        }
        private async Task InitializeAuthorizationStatusAsync()
        {
            var loggedInUser = userService.GetLoggedInUserAsync();
            if (loggedInUser != null)
            {
                _isAuthorized = await userService.IsUserAdminAsync(loggedInUser);
            }
            else
            {
                _isAuthorized = false;
            }
        }

        private async Task CreateRoomButtons(RoomViewModel room, Panel container, User activeUser)
        {
            var readMoreButton = new Button
            {
                Text = "Read more",
                BackColor = Color.LightPink,
                Size = new Size(112, 29),
                Location = new Point(0, 215)
            };
            readMoreButton.Click += (s, e) =>
            {
                RoomDetailsViewModel model = new RoomDetailsViewModel
                {
                    Id = room.Id,
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
                Location = new Point(112, 215)
            };
            reserveButton.Click += async (s, e) =>
            {
                if (room.IsAvailable)
                {
                    Reservate reservateForm = new Reservate();
                    Program.SwitchMainForm(reservateForm);
                }
                MessageBox.Show(RoomIsAlreadyReservated, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            };
            container.Controls.Add(reserveButton);

            if (_isAuthorized)
            {
                var editButton = new Button
                {
                    Text = "Edit",
                    BackColor = Color.LightGray,
                    Size = new Size(112, 29),
                    Location = new Point(0, 244)
                };
                editButton.Click += (s, e) =>
                {
                    EditRoomInputModel model = new EditRoomInputModel()
                    {
                        Id = room.Id,
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
                    Location = new Point(112, 244)
                };
                deleteButton.Click += async (s, e) =>
                {
                    var success = await roomService.DeleteRoomAsync(room.Id);
                    if (success)
                    {
                        MessageBox.Show(RoomDeletionSuccessful, "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await PopulateRoomsPanelAsync(container, activeUser);
                    }
                    else
                    {
                        MessageBox.Show(RoomDeletionFailed, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
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

                // Add labels and image box
                var typeLabel = CreateLabel($"typeLabel{index}", room.Type.ToString(), FontsPicker.BaseFont, new Point(78, 166));
                var priceLabel = CreateLabel($"priceLabel{index}", $"{room.Price:f2}lv", FontsPicker.DetailsFont, new Point(30, 190));
                var availabilityLabel = CreateLabel($"availabilityLabel{index}", room.IsAvailable ? "Available" : "Not Available", FontsPicker.DetailsFont, new Point(130, 190));

                PictureBox image = new PictureBox()
                {
                    Name = $"pictureBox{index}"
                     ,
                    ImageLocation = room.PictureLocation
                };

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
                AutoSize = true
            };
        }

        private async void Rooms_Load(object sender, EventArgs e)
        {
            await InitializeAuthorizationStatusAsync();

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
    }
}
