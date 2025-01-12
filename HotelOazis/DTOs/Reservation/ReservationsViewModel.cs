using HotelOazis.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.DTOs.Reservation
{
    public class ReservationsViewModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
        public string PictureLocation { get; set; } = null!;
        public int RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
