using HomeSite.ClassLibrary.Web.Mvc.Controllers;
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
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Privacy method
        /// </summary>
        /// <returns>IActionResult</returns>
        /// <method>Privacy()</method>
        public IActionResult Privacy()
        {
            //throw new System.Exception("Test Exception");
            return StatusCode(402);
            //return View();
        }

        ///// <summary>
        ///// Global error handling
        ///// </summary>
        ///// <param name="id">int</param>
        ///// <returns>IActionResult</returns>
        //[AllowAnonymous]
        //[HttpGet]
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error(int id) : base(id)
        //{
        //}
    }
}
