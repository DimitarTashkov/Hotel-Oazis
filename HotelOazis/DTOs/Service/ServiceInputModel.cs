using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HotelOazis.Common.Constants.ValidationConstants.ServiceConstants;


namespace HotelOazis.DTOs.Service
{
    public class ServiceInputModel
    {
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
    }
}
