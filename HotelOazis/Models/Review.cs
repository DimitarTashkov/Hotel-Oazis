using HotelOazis.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HotelOazis.Common.Constants.ValidationConstants.ReviewConstants;

namespace HotelOazis.Models
{
    public class Review
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(MessageMaxLength)]
        public string Message { get; set; } = null!;

        [Required]
        [Range(RatingMinRange,RatingMaxRange)]
        public int Rating { get; set; }
        [Required]
        public FeedbackStatus MessageStatus { get; set; }
        [Required]
        public DateTime PublishedOn { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
