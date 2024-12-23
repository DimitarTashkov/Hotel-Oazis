using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } 

        [Required]
        [StringLength(50)]
        public string Username { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Password { get; set; } = null!;
        public int? Age { get; set; }
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string AvatarUrl { get; set; } = null!;
        public virtual HashSet<Reservation> Reservations { get; set; }
        = new HashSet<Reservation>();

    }
}
