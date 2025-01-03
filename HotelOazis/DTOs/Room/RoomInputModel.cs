﻿using HotelOazis.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HotelOazis.Common.Messages.ErrorMessages.RoomMessages;

namespace HotelOazis.DTOs.Room
{
    public class RoomInputModel
    {
        [Required(ErrorMessage = RoomTypeIsRequired)]
        public RoomType Type { get; set; }

        [Required(ErrorMessage = PriceIsRequired)]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
 
    }
}
