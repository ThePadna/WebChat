using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebChat.Areas.Identity.Data;
using WebChat.Areas.Identity.Data.Message;
using WebChat.DAL;

namespace WebChat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    DbInitializer dbInitializer = new DbInitializer();
                    var appUserDBContext = services.GetRequiredService<AppUserDBContext>();
                    dbInitializer.Initialize(appUserDBContext);
                    var messageModelDBContext = services.GetRequiredService<MessageModelDBContext>();
                    dbInitializer.Initialize(messageModelDBContext);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
