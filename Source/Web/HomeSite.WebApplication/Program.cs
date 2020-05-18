using HomeSite.ClassLibrary.Commons.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;

namespace HomeSite.WebApplication
{
    /// <summary>
    /// Entry point class
    /// </summary>
    /// <revision>
    /// __Revisions:__~~
    /// | Contributor | Build | Revison Date | Description |~
    /// |-------------|-------|--------------|-------------|~
    /// | Christopher D. Cavell | 0.0.1 | 05/17/2020 | Initial build |~ 
    /// </revision>
    public class Program
    {
        private static string _environmentName;
        private static Logger _logger;

        /// <summary>
        /// Entry point method
        /// </summary>
        /// <param name="args">string[]</param>
        /// <method>Main(string[] args)</method>
        public static void Main(string[] args)
        {
            _environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToLower();

            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            _logger = new Logger(serviceProvider.GetService<ILogger<Program>>());

            try
            {
                _logger.Information($"Program Started");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception e)
            {
                _logger.Exception(e, $"Program Exception Error");
            }
            finally
            {
                _logger.Information($"Program Ended");
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            if (Equals(_environmentName, "development"))
                services.AddLogging(configure => configure.AddDebug());
            else
                services.AddLogging(configure => configure.AddConsole());
        }

        /// <summary>
        /// Host Builder configuration
        /// </summary>
        /// <param name="args">string[]</param>
        /// <returns>IHostBuilder</returns>
        /// <method>CreateHostBuilder(string[] args)</method>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                    logging.AddConsole();
                    logging.AddApplicationInsights("ikey");
                    logging.AddEventLog(eventLogSettings =>
                    {
                        eventLogSettings.SourceName = Assembly.GetEntryAssembly().GetName().Name;
                        eventLogSettings.LogName = "Application";
                    });

                    if (Equals(_environmentName, "development"))
                        logging.AddDebug();
                })
                .ConfigureAppConfiguration((hostContext, configApp) =>
                {
                    configApp.AddJsonFile("appsettings.json", optional: true);
                    configApp.AddJsonFile($"appsettings.{hostContext.HostingEnvironment.EnvironmentName}.json", optional: false);
                    configApp.AddEnvironmentVariables(prefix: "PREFIX_");
                    configApp.AddCommandLine(args);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStaticWebAssets();
                    webBuilder.UseStartup<Startup>();
                });
    }
}
