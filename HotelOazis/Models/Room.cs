using System;
using System.Collections.Generic;
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
        [StringLength(50)]
        public string Type { get; set; } = null!;

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
    }
}
