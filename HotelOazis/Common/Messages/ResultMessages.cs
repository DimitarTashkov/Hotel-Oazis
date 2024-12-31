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
            public const string ProfileDeletionSuccessful = "Your account has been successfully deleted!";
            public const string ProfileDeletionFailed = "Failed to delete the account! Please try again!";
        }
    }
}
