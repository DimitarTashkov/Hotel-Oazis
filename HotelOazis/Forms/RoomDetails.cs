﻿using Fitness.Services;
using HotelOazis.DTOs.Reservation;
using HotelOazis.DTOs.Room;
using HotelOazis.Extensions;
using HotelOazis.Migrations;
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
using System.Xml.Linq;

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

            string availabilityMessage = model.IsAvailable ? IsAvailable : IsNotAvailable;
            roomType.Text = roomType.Text + " " + model.Type.ToString();
            roomNumber.Text = roomNumber.Text + " " + model.RoomNumber.ToString();
            roomPrice.Text = roomPrice.Text + " " + $"{model.Price.ToString():f2} lv";
            roomAvaialability.Text = roomAvaialability.Text + " " + availabilityMessage;
            roomDescription.Text = roomDescription.Text + " " + model.Description;
            roomDescription.MaximumSize = new Size(roomDataContainer.Size.Width, 50);
            roomDescription.AutoSize = true;
            roomImage.ImageLocation = model.Picture;

            CreateIconControls();
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
