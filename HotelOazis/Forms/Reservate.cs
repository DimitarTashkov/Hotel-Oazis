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
        private readonly IRoomService roomService;
        private readonly IUserService userService;
        private readonly ReservationInputModel model;
        public Reservate(IRoomService roomService, ReservationInputModel model)
        {
            this.roomService = roomService;
            this.model = model;
            this.userService = ServiceLocator.GetService<IUserService>();
            InitializeComponent();
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);

        }

        private async void reservateBtn_Click(object sender, EventArgs e)
        {
            DateTime checkInDate = checkInDatePicker.Value;
            DateTime checkOutDate = checkOutDatePicker.Value;

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
    }
}
