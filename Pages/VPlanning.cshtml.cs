using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class VPlanningModel : PageModel
    {
        private readonly ILogger<VPlanningModel> _logger;

        public VPlanningModel(ILogger<VPlanningModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
