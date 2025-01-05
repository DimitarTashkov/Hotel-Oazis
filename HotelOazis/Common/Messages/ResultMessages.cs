using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.Common.Messages
{
    public static class ResultMessages
    {
        public static class UserMessages
        {
            public const string ProfileRegisteredSuccessfully = "Profile registered successfully!";
            public const string ProfileUpdatedSuccessfully = "Profile updated successfully!";
            public const string ProfileUpdateFailed = "Failed to update profile! Please try again!";
            public const string ProfileDeleteWarning = "Are you sure you want to delete your account? This action cannot be undone!";
            public const string ProfileDeletionSuccessful = "Your account has been deleted successfully!";
            public const string ProfileDeletionFailed = "Failed to delete the account! Please try again!";
        }
        public static class RoomMessages
        {
            public const string RoomCreatedSuccessfully = "Room created successfully!";
            public const string RoomCreationFailed = "Failed to create room! Please try again!";
            public const string RoomUpdatedSuccessfully = "Room updated successfully!";
            public const string RoomUpdateFailed = "Failed to update room! Please try again!";
            public const string RoomDeletionSuccessful = "Your room has been deleted successfully!";
            public const string RoomDeletionFailed = "Failed to delete the room! Please try again!";
        }
    }
}
