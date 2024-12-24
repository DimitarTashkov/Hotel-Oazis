﻿using HotelOazis.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.Models
{
    public class Room
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public RoomType Type { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsAvailable { get; set; }
        public virtual HashSet<Service> Services { get; set; }
        = new HashSet<Service>();
    }
}
