using HotelOazis.DTOs.User;
using HotelOazis.Models.DbConfiguration;
using HotelOazis.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.Services
{
    public class UserService : IUserService
    {
        private readonly HotelContext _dbContext;

        public UserService(HotelContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AuthenticateUserAsync(string username, string password)
        {
            return await _dbContext.Users
                .AnyAsync(u => u.Username == username && u.Password == password);
        }

        public async Task<(bool IsValid, List<ValidationResult> Errors)> ValidateLoginAsync(LoginUserInputModel loginModel)
        {
            return await Task.Run(() =>
            {
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(loginModel);
                bool isValid = Validator.TryValidateObject(loginModel, validationContext, validationResults, true);
                return (isValid, validationResults);
            });
        }
    }
}
