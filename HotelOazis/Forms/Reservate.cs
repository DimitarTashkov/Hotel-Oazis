using Fitness.Services;
using HotelOazis.DTOs.Reservation;
using HotelOazis.DTOs.Room;
using HotelOazis.Extensions;
using HotelOazis.Models;
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

using static HotelOazis.Common.Messages.ErrorMessages.ReservationMessages;
using static HotelOazis.Common.Messages.ResultMessages.ActionMessages;

namespace HotelOazis.Forms
{
    public partial class Reservate : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly IReviewService reviewService;
        private readonly IRoomService roomService;
        private readonly ReservationInputModel model;
        private User activeUser;
        public Reservate(IRoomService roomService, ReservationInputModel model)
        {
            this.model = model;
            this.roomService = roomService;
            this.userService = ServiceLocator.GetService<IUserService>();
            this.facilityService = ServiceLocator.GetService<IFacilityService>();
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            activeUser = userService.GetLoggedInUserAsync();
            InitializeComponent();
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);

        }

        private async void reservateBtn_Click(object sender, EventArgs e)
        {
            DateTime checkInDate = checkInDatePicker.Value;
            DateTime checkOutDate = checkOutDatePicker.Value;

            bool isReserved = await roomService.IsRoomReservedBetweenDatesAsync(model.RoomId, checkInDate, checkOutDate);
            if (isReserved)
            {
                MessageBox.Show(RoomIsAlreadyReservated, "Reservation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (checkInDate >= checkOutDate)
            {
                MessageBox.Show(InvalidCheckOutDate, "Reservation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            model.CheckInDate = checkInDate;
            model.CheckOutDate = checkOutDate;

            bool isCreated = await roomService.ReserveRoomAsync(model);
            if (isCreated)
            {
                MessageBox.Show(string.Format(CreatedSuccessfully, nameof(Reservation)), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reservations roomsForm = new Reservations(userService, roomService);
                Program.SwitchMainForm(roomsForm);
            }
            else
            {
                MessageBox.Show(string.Format(CreationFailed, nameof(Reservation)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Rooms roomsForm = new Rooms(roomService, userService);
            Program.SwitchMainForm(roomsForm);
        }

        private void Reservate_Load(object sender, EventArgs e)
        {
            bool isAdmin = AuthorizationHelper.IsAuthorized();

            if (isAdmin)
            {
                Users.Visible = true;
                Reservations.Visible = true;
            }

            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;
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
