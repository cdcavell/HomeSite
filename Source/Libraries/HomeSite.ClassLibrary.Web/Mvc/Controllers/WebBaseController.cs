using HomeSite.ClassLibrary.Commons.Logging;
using HomeSite.ClassLibrary.Web.Html;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net;

namespace HomeSite.ClassLibrary.Web.Mvc.Controllers
{
    /// <class>WebBaseController</class>
    /// <summary>
    /// Base controller class for web application
    /// </summary>
    /// <revision>
    /// __Revisions:__~~
    /// | Contributor | Build | Revison Date | Description |~
    /// |-------------|-------|--------------|-------------|~
    /// | Christopher D. Cavell | 0.0.1 | 05/16/2020 | Initial build |~ 
    /// </revision>
    [Controller]
    [Authorize]
    public abstract class WebBaseController<T> : Controller where T : WebBaseController<T>
    {
        /// <value>ILogger</value>
        protected readonly Logger _logger;
        /// <value>IWebHostEnvironment</value>
        protected readonly IWebHostEnvironment _webHostEnvironment;
        /// <value>IWebHostEnvironment</value>
        protected readonly IHttpContextAccessor _httpContextAccessor;

        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="logger">ILogger</param>
        /// <param name="webHostEnvironment">IWebHostEnvironment</param>
        /// <param name="httpContextAccessor">IHttpContextAccessor</param>
        /// <method>WebBaseController(ILogger&lt;T&gt; logger, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)</method>
        protected WebBaseController(ILogger<T> logger, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _logger = new Logger(logger);
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Global model validation method
        /// </summary>
        /// <param name="model">Model</param>
        /// <returns>KeyValuePair&lt;int, string&gt;</returns>
        /// <method>ValidateModel&lt;M&gt;(M model)</method>
        protected KeyValuePair<int, string> ValidateModel<M>(M model)
        {
            int key = 0;
            string value = string.Empty;

            bool isValid = TryValidateModel(model);
            if (!isValid)
            {
                foreach (var modelValue in ModelState.Values)
                {
                    var errors = modelValue.Errors;
                    if (errors.Count > 0)
                    {
                        foreach (var error in errors)
                        {
                            key++;
                            value += Tags.Brackets(error.ErrorMessage) + Tags.LineBreak();
                        }
                    }
                }
            }

            return new KeyValuePair<int, string>(key, value);
        }

        /// <summary>
        /// Global error handling
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IActionResult</returns>
        [AllowAnonymous]
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int id)
        {
            return BadRequest();
        }
    }
}
