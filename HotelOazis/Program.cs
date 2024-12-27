using HotelOazis.Forms;
using HotelOazis.Models.DbConfiguration;
using HotelOazis.Services;
using HotelOazis.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelOazis
{
    internal static class Program
    {
        public static ApplicationContext AppContext;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Configure DbContext
            services.AddDbContext<HotelContext>(options =>
                options.UseSqlServer(Configuration.ConnectionString));

            // Register services
            services.AddScoped<IUserService, UserService>();

            var serviceProvider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dbContext = serviceProvider.GetRequiredService<HotelContext>();
            AppContext = new ApplicationContext(new Login(dbContext));
            Application.Run(AppContext);
        }
        public static void SwitchMainForm(Form newForm)
        {
            var oldMainForm = AppContext.MainForm;
            AppContext.MainForm = newForm;
            oldMainForm?.Hide();
            oldMainForm?.Close();
            newForm.ShowDialog();
        }
    }
}