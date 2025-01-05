using HotelOazis.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.DTOs.Room
{
    public class RoomDetailsViewModel
    {
        public Guid Id { get; set; }
        public RoomType Type { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Picture { get; set; } = null!;
        public string? Description { get; set; }
    }
}
