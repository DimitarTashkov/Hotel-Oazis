using HotelOazis.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.DTOs.Review
{
    public class ReviewViewModel
    {
        public Guid Id { get; set; }
        public string Messages { get; set; } = null!;
        public int Rating { get; set; }
        public FeedbackStatus MessageStatus { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Username { get; set; } = null!;
        public string ProfilePicture { get; set; } = null!;
    }
}
