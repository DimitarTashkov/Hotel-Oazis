using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.Models
{
    public class Service
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(500)]
        public string Description { get; set; } = null!;

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
