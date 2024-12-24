using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.Common.Messages
{
    public static class ErrorMessages
    {
        public static class RoomMessages
        {
            public const string RoomTypeIsRequired = "Selecting room type is required";
            public const string PriceIsRequired = "Defining price is required";
            public const string IsAvailableRequired = "Room status is required";
        }
        public static class UserMessages
        {
            public const string UsernameIsRequired = "Username is required ";
            public const string PasswordIsRequired = "Password is required";
            public const string EmailIsRequired = "Email is required";
            public const string AvatarIsRequired = "Profile picture is required";

        }
    }
}
