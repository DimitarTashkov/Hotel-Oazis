﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HotelOazis.Common.Constants.ValidationConstants.UserConstants;
using static HotelOazis.Common.Messages.ErrorMessages.UserMessages;


namespace HotelOazis.DTOs.User
{
    public class RegisterUserInputModel
    {
        [Required(ErrorMessage = UsernameIsRequired)]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = PasswordIsRequired)]
        [MinLength(PasswordMinLength)]
        [MaxLength(PasswordMaxLength)]
        public string Password { get; set; } = null!;

        public int? Age { get; set; }

        [Required(ErrorMessage = EmailIsRequired)]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = AvatarIsRequired)]
        public string AvatarUrl { get; set; } = null!;
    }
}
