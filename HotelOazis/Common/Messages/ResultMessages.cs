﻿using System;
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
        public static class ActionMessages
        {
            public const string CreatedSuccessfully = "{0} created successfully!";
            public const string CreationFailed = "Failed to create {0}! Please try again!";
            public const string UpdatedSuccessfully = "{0} updated successfully!";
            public const string UpdateFailed = "Failed to update {0}! Please try again!";
            public const string DeletionSuccessful = "{0} has been deleted successfully!";
            public const string DeletionFailed = "Failed to delete the {0}! Please try again!";
        }

    }
}
