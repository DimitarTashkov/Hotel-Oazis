using HotelOazis.DTOs.User;
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
    public class UserService : BaseService ,IUserService
    {
        private readonly HotelContext dbContext;

        private User? loggedInUser;

        public UserService(HotelContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> AuthenticateUserAsync(string username, string password)
        {
            var user = await dbContext.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                loggedInUser = user; 
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

            dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync();
        }

        public User? GetLoggedInUserAsync()
        {
            return loggedInUser;
        }

        public async Task<bool> UpdateUserAsync(EditProfileInputModel userModel)
        {
            if (loggedInUser == null) return false;

            var user = await dbContext.Users.FindAsync(loggedInUser.Id);
            if (user == null) return false;

            user.Username = userModel.Username;
            user.Email = userModel.Email;
            user.Age = userModel.Age;
            user.AvatarUrl = userModel.AvatarUrl;

            dbContext.Users.Update(user);
            await dbContext.SaveChangesAsync();

            loggedInUser = user; 
            return true;
        }

        public async Task<bool> DeleteUserAsync()
        {
            if (loggedInUser == null) return false;

            var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Id == loggedInUser.Id);
            if (user == null) return false;

            dbContext.Users.Remove(user);
            await dbContext.SaveChangesAsync();

            loggedInUser = null; 
            return true;
        }
        public async Task<bool> IsUserAdminAsync(User user)
        {
            return await dbContext.UsersRoles
                .AnyAsync(ur => ur.UserId == user.Id && ur.Role.Name == "Admin");
        }
        public void LogoutUser()
        {
            loggedInUser = null; 
        }
        public async Task<bool> IsUsernameTaken(string username)
        {
            return await dbContext.Users.AnyAsync(u => u.Username == username);
        }

    }
}
