﻿using HotelOazis.DTOs.User;
using HotelOazis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.Services.Interfaces
{
    public interface IUserService : IValidateModel
    {
        public Task<bool> AuthenticateUserAsync(string username, string password);
        public Task RegisterUserAsync(RegisterUserInputModel registrationModel);
        public Task<bool> UpdateUserAsync(EditProfileInputModel user);
        public User? GetLoggedInUserAsync();
        public Task<bool> DeleteUserAsync();
        public void LogoutUser();
        Task<bool> IsUserAdminAsync(User user);
        public Task<bool> IsUsernameTaken(string username);


    }
}
