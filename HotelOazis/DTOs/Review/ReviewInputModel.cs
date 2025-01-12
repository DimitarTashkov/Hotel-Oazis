using HotelOazis.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HotelOazis.Common.Constants.ValidationConstants.ReviewConstants;
using static HotelOazis.Common.Messages.ErrorMessages.ReviewsMessages;

namespace HotelOazis.DTOs.Review
{
    public class ReviewInputModel
    {
        [Required(ErrorMessage =MessageIsRequired)]
        [MinLength(MessageMinLength)]
        [MaxLength(MessageMaxLength)]
        public string Message { get; set; } = null!;

        [Required]
        [Range(RatingMinRange,RatingMaxRange)]
        [DefaultValue(0)]

        public int Rating { get; set; }
        [Required]
        [DefaultValue(FeedbackStatus.Unverified)]

        public FeedbackStatus MessageStatus { get; set; }
        [Required]

        public DateTime PublishedOn { get; set; }

        [Required]
        public Guid UserId { get; set; }
    }
}
