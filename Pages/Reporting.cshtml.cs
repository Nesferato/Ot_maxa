using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class ReportingModel : PageModel
    {
        private readonly ILogger<ReportingModel> _logger;

        public ReportingModel(ILogger<ReportingModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
