using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HotelOazis.Common.Constants.ValidationConstants.ServiceConstants;
using static HotelOazis.Common.Messages.ErrorMessages.ServicesMessages;



namespace HotelOazis.DTOs.Service
{
    public class ServiceInputModel
    {
        [Required(ErrorMessage =ServiceNameIsRequired)]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage =ServiceDescriptionIsRequired)]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
    }
}
