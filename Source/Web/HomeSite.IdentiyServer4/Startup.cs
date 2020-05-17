using HomeSite.ClassLibrary.Commons.Logging;
using HomeSite.ClassLibrary.Web.Security;
using HomeSite.IdentiyServer4.Models.AppSettings;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace HomeSite.IdentiyServer4
{
    /// <summary>
    /// The Startup class configures services and the application's request pipeline&lt;br /&gt;&lt;br /&gt;
    /// _Services_ are components that are used by the app. For example, a logging component is a service. Code to configure (_or register_) services is added to the ```Startup.ConfigureServices``` method.&lt;br /&gt;&lt;br /&gt;
    /// The request handling pipeline is composed as a series of _middleware_ components. For example, a middleware might handle requests for static files or redirect HTTP requests to HTTPS. Each middleware performs asynchronous operations on an ```HttpContext``` and then either invokes the next middleware in the pipeline or terminates the request. Code to configure the request handling pipeline is added to the ```Startup.Configure``` method.
    /// </summary>
    /// <revision>
    /// __Revisions:__~~
    /// | Contributor | Build | Revison Date | Description |~
    /// |-------------|-------|--------------|-------------|~
    /// | Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial commit |~ 
    /// </revision>
    public class Startup
    {
        private IConfiguration _configuration;
        private Logger _logger;

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="configuration">IConfiguration</param>
        /// <method>Startup(IConfiguration configuration)</method>
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// This optional method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        /// <method>ConfigureServices(IServiceCollection services)</method>
        public void ConfigureServices(IServiceCollection services)
        {
            AppSettings appSettings = new AppSettings();
            _configuration.Bind("AppSettings", appSettings);    
            services.AddSingleton(appSettings);

            IdentityModelEventSource.ShowPII = true;
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            services.AddMvc();
            services.AddControllersWithViews();

            services.AddAuthentication("cookie")
                .AddCookie("cookie");

            services.AddIdentityServer()
                .AddInMemoryClients(Clients.Get())
                .AddInMemoryIdentityResources(Resources.GetIdentityResources())
                .AddInMemoryApiResources(Resources.GetApiResources())
                .AddTestUsers(Users.Get())
                .AddDeveloperSigningCredential();
        }

        /// <summary>
        /// This required method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">IApplicationBuilder</param>
        /// <param name="env">IWebHostEnvironment</param>
        /// <param name="logger">ILogger&lt;Startup&gt;</param>
        /// <param name="lifetime">IHostApplicationLifetime</param>
        /// <method>Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger&lt;Startup&gt; logger, IHostApplicationLifetime lifetime)</method>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger, IHostApplicationLifetime lifetime)
        {
            _logger = new Logger(logger);
            _logger.Trace($"Configure(IApplicationBuilder: {app}, IWebHostEnvironment: {env}, ILogger<Startup> {logger}, IHostApplicationLifetime: {lifetime})");

            lifetime.ApplicationStarted.Register(OnAppStarted);
            lifetime.ApplicationStopping.Register(OnAppStopping);
            lifetime.ApplicationStopped.Register(OnAppStopped);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseIdentityServer();

            app.UseStaticFiles();
            app.UseRouting();

            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
        }

        /// <summary>
        /// Exposed IApplicationLifetime interface method.
        /// </summary>
        /// <method>OnAppStarted()</method>
        public void OnAppStarted()
        {
            AESGCM.Seed(_configuration);
            _logger.Information($"Application Started {DateTime.Now.ToUniversalTime()}");
        }

        /// <summary>
        /// Exposed IApplicationLifetime interface method.
        /// </summary>
        /// <method>OnAppStopping()</method>
        public void OnAppStopping()
        {
            _logger.Information($"Application Shutdown {DateTime.Now.ToUniversalTime()}");
        }

        /// <summary>
        /// Exposed IApplicationLifetime interface method.
        /// </summary>
        /// <method>OnAppStopped()</method>
        public void OnAppStopped()
        {
            _logger.Information($"Application Ended {DateTime.Now.ToUniversalTime()}");
        }

        internal class Clients
        {
            public static IEnumerable<Client> Get()
            {
                return new List<Client> {
                new Client {
                    ClientId = "oauthClient",
                    ClientName = "Example Client Credentials Client Application",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret> {
                        new Secret("superSecretPassword".Sha256())},
                        AllowedScopes = new List<string> {"customAPI.read"}
                    }
                };
            }
        }

        internal class Resources
        {
            public static IEnumerable<IdentityResource> GetIdentityResources()
            {
                return new List<IdentityResource> {
                    new IdentityResources.OpenId(),
                    new IdentityResources.Profile(),
                    new IdentityResources.Email(),
                    new IdentityResource {
                        Name = "role",
                        UserClaims = new List<string> {"role"}
                    }
                };
            }

            public static IEnumerable<ApiResource> GetApiResources()
            {
                return new List<ApiResource> {
                    new ApiResource {
                        Name = "customAPI",
                        DisplayName = "Custom API",
                        Description = "Custom API Access",
                        UserClaims = new List<string> {"role"},
                        ApiSecrets = new List<Secret> {new Secret("scopeSecret".Sha256())},
                        Scopes = new List<Scope> {
                            new Scope("customAPI.read"),
                            new Scope("customAPI.write")
                        }
                    }
                };
            }
        }

        internal class Users
        {
            public static List<TestUser> Get()
            {
                return new List<TestUser> {
                    new TestUser {
                        SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
                        Username = "scott",
                        Password = "password",
                        Claims = new List<Claim> {
                            new Claim(JwtClaimTypes.Email, "scott@scottbrady91.com"),
                            new Claim(JwtClaimTypes.Role, "admin")
                        }
                    }
                };
            }
        }


    }
}
