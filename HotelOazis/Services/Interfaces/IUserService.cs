using HotelOazis.DTOs.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.Services.Interfaces
{
    public interface IUserService
    {
        public Task<(bool IsValid, List<ValidationResult> Errors)> ValidateModelAsync<TModel>(TModel model);
        public Task<bool> AuthenticateUserAsync(string username, string password);
        public Task RegisterUserAsync(RegisterUserInputModel registrationModel);
    }
}
