using HotelOazis.Models.DbConfiguration;
using HotelOazis.Services.Interfaces;
using HotelOazis.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelOazis.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddHotelServices(this IServiceCollection services)
        {
            services.AddDbContext<HotelContext>(options =>
                options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoomService, RoomService>();
            return services;
        }
    }
}
