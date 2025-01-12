using Fitness.Utilities;
using HotelOazis.Common.Constants;
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

namespace HotelOazis.Forms
{
    public partial class Reservations : Form
    {
        private readonly IUserService userService;
        private readonly IRoomService roomService;
        private static bool isAuthorized;
        public Reservations(IUserService userService, IRoomService roomService)
        {
            this.userService = userService;
            this.roomService = roomService;
            InitializeComponent();
        }

        private async void Reservations_Load(object sender, EventArgs e)
        {
            //TODO: add icons to labels
            var reservations = await roomService.GetReservationsAsync();

            foreach (var reservation in reservations)
            {
                int daysReserved = (reservation.CheckOutDate - reservation.CheckInDate).Days;
                decimal totalPrice = reservation.PricePerNight * daysReserved;

                FlowLayoutPanel reservationContainer = new FlowLayoutPanel
                {
                    Name = $"reservationContainer_{reservation.Id}",
                    Size = new Size(725, 120),
                    Margin = new Padding(8),
                    BackColor = Color.RosyBrown,
                    FlowDirection = FlowDirection.TopDown,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    WrapContents = false
                };

                RoundPictureBox userAvatar = new RoundPictureBox
                {
                    Name = $"userAvatar_{reservation.Id}",
                    Size = new Size(50, 50),
                    ImageLocation = reservation.PictureLocation,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left
                };

                reservationContainer.Controls.Add(userAvatar);

                reservationContainer.Controls.Add(CreateLabel(
                    $"Room {reservation.RoomNumber} ({reservation.RoomType})",
                    FontsPicker.DetailsFont.Name,
                    FontsPicker.DetailsFont.Size,
                    FontStyle.Bold));

                reservationContainer.Controls.Add(CreateLabel(
                    $"Days Reserved: {daysReserved}",
                    FontsPicker.DetailsFont.Name,
                    FontsPicker.DetailsFont.Size));

                reservationContainer.Controls.Add(CreateLabel(
                    $"Total Price: ${totalPrice}",
                    FontsPicker.DetailsFont.Name,
                    FontsPicker.DetailsFont.Size));

                reservationContainer.Controls.Add(CreateLabel(
                    $"Check-in: {reservation.CheckInDate:yyyy-MM-dd} \nCheck-out: {reservation.CheckOutDate:yyyy-MM-dd}",
                    FontsPicker.DetailsFont.Name,
                    FontsPicker.DetailsFont.Size));

                reservationContainer.Controls.Add(CreateLabel(
                    $"Reserved by: {reservation.Username}",
                    FontsPicker.DetailsFont.Name,
                    FontsPicker.DetailsFont.Size));

                Button cancelReservationButton = CreateButton(
                    "Cancel",
                    Color.Red,
                    Color.White,
                    100,
                    30,
                    $"cancelReservation_{reservation.Id}");
                cancelReservationButton.Font = FontsPicker.DetailsFont;
                cancelReservationButton.Anchor = AnchorStyles.None;
                cancelReservationButton.Margin = new Padding(0);

                cancelReservationButton.Click += async (s, ev) =>
                {
                    var confirm = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancellation", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        bool success = await roomService.CancelReservationAsync(reservation.Id);
                        if (success)
                        {
                            MessageBox.Show("Reservation canceled successfully.");
                            reservationsContainer.Controls.Remove(reservationContainer);
                        }
                        else
                        {
                            MessageBox.Show("Failed to cancel reservation. Please try again.");
                        }
                    }
                };

                reservationContainer.Controls.Add(cancelReservationButton);

                reservationsContainer.Controls.Add(reservationContainer);
            }
        }
        private Label CreateLabel(string text, string fontName, float fontSize, FontStyle fontStyle = FontStyle.Regular)
        {
            return new Label
            {
                Text = text,
                Font = new Font(fontName, fontSize, fontStyle),
                AutoSize = true,
                Margin = new Padding(5),
                TextAlign = ContentAlignment.MiddleCenter
            };
        }


        private Button CreateButton(string text, Color backColor, Color foreColor, int width, int height, string name)
        {
            return new Button
            {
                Text = text,
                BackColor = backColor,
                ForeColor = foreColor,
                Size = new Size(width, height),
                Name = name,
                Margin = new Padding(5)
            };
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Index indexForm = new Index(userService);
            Program.SwitchMainForm(indexForm);
        }
    }
}
