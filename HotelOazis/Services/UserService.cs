﻿using HotelOazis.DTOs.User;
using HotelOazis.Models;
using HotelOazis.Models.DbConfiguration;
using HotelOazis.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelOazis.Services
{
    public class UserService : IUserService
    {
        private readonly HotelContext _dbContext;

        private User? _loggedInUser;

        public UserService(HotelContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AuthenticateUserAsync(string username, string password)
        {
            var user = await _dbContext.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                _loggedInUser = user; 
                return true;
            }

            return false;
        }

        public async Task RegisterUserAsync(RegisterUserInputModel registrationModel)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = registrationModel.Username,
                Password = registrationModel.Password,
                Age = registrationModel.Age,
                Email = registrationModel.Email,
                AvatarUrl = registrationModel.AvatarUrl
            };

            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public User? GetLoggedInUserAsync()
        {
            return _loggedInUser;
        }

        public async Task<bool> UpdateUserAsync(EditProfileInputModel userModel)
        {
            if (_loggedInUser == null) return false;

            var user = await _dbContext.Users.FindAsync(_loggedInUser.Id);
            if (user == null) return false;

            user.Username = userModel.Username;
            user.Email = userModel.Email;
            user.Age = userModel.Age;
            user.AvatarUrl = userModel.AvatarUrl;

            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();

            _loggedInUser = user; 
            return true;
        }

        public async Task<(bool IsValid, List<ValidationResult> Errors)> ValidateModelAsync<TModel>(TModel model)
        {
            return await Task.Run(() =>
            {
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(model);
                bool isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);
                return (isValid, validationResults);
            });
        }
        public async Task<EditProfileInputModel?> GetUserForEditAsync()
        {
            if (_loggedInUser == null) return null;


            var user = await _dbContext.Users
                .Select(u => new EditProfileInputModel
                {
                    Id = u.Id,
                    Username = u.Username,
                    Password = u.Password,
                    Age = u.Age,
                    Email = u.Email,
                    AvatarUrl = u.AvatarUrl
                })
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == _loggedInUser.Id);

            return user;
        }
    }
}
