using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class PlanningModel : PageModel
    {
        private readonly ILogger<PlanningModel> _logger;

        public PlanningModel(ILogger<PlanningModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
