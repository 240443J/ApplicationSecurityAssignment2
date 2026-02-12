using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;

namespace WebApp_Core_identity.Pages
{
    public class Error404Model : PageModel
    {
        private readonly ILogger<Error404Model> _logger;

        public Error404Model(ILogger<Error404Model> logger)
        {
          _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogWarning("404 Error: Page not found - Path: {Path}, IP: {IP}",
           HttpUtility.HtmlEncode(HttpContext.Request.Path),
          HttpUtility.HtmlEncode(HttpContext.Connection.RemoteIpAddress?.ToString()));
        }
    }
}
