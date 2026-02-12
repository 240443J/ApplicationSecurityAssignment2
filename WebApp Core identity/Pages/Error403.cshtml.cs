using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;

namespace WebApp_Core_identity.Pages
{
    public class Error403Model : PageModel
    {
private readonly ILogger<Error403Model> _logger;

        public Error403Model(ILogger<Error403Model> logger)
        {
            _logger = logger;
        }

   public void OnGet()
      {
            _logger.LogWarning("403 Error: Access denied - Path: {Path}, User: {User}, IP: {IP}",
        HttpUtility.HtmlEncode(HttpContext.Request.Path),
       HttpUtility.HtmlEncode(User.Identity?.Name ?? "Anonymous"),
                HttpUtility.HtmlEncode(HttpContext.Connection.RemoteIpAddress?.ToString()));
        }
    }
}
