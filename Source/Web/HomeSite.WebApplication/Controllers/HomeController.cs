using HomeSite.ClassLibrary.Web.Mvc.Controllers;
using HomeSite.WebApplication.Models.AppSettings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeSite.IdentiyServer4.Controllers
{
    /// <summary>
    /// Home controller class
    /// </summary>
    /// <revision>
    /// __Revisions:__~~
    /// | Contributor | Build | Revison Date | Description |~
    /// |-------------|-------|--------------|-------------|~
    /// | Christopher D. Cavell | 0.0.1 | 05/17/2020 | Initial build |~ 
    /// </revision>
    public class HomeController : WebBaseController<HomeController>
    {
        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="logger">ILogger</param>
        /// <param name="webHostEnvironment">IWebHostEnvironment</param>
        /// <param name="httpContextAccessor">IHttpContextAccessor</param>
        /// <method>HomeController(ILogger&lt;HomeController&gt; logger, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)</method>
        public HomeController(
            ILogger<HomeController> logger, 
            IWebHostEnvironment webHostEnvironment, 
            IHttpContextAccessor httpContextAccessor
        ) : base (logger, webHostEnvironment, httpContextAccessor)
        {
        }

        /// <summary>
        /// Index method
        /// </summary>
        /// <returns>IActionResult</returns>
        /// <method>Index()</method>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// About method
        /// </summary>
        /// <returns>IActionResult</returns>
        /// <method>About()</method>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        /// <summary>
        /// Products method
        /// </summary>
        /// <returns>IActionResult</returns>
        /// <method>Products()</method>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Products()
        {
            return View();
        }

        /// <summary>
        /// Store method
        /// </summary>
        /// <returns>IActionResult</returns>
        /// <method>Store()</method>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Store()
        {
            return View();
        }

        /// <summary>
        /// Location method
        /// </summary>
        /// <returns>IActionResult</returns>
        /// <method>Location()</method>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Location()
        {
            return View();
        }
    }
}
