using HotelOazis.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HotelOazis.Common.Constants.ValidationConstants.UserConstants;

namespace HotelOazis.DTOs.Room
{
    public class RoomViewModel
    {
        public Guid Id { get; set; }

        public RoomType Type { get; set; }

        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string PictureLocation { get; set; } = null!;
    }
}
