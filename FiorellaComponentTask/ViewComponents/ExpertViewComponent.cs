using Microsoft.AspNetCore.Mvc;

namespace FiorellaComponentTask.ViewComponents
{
    public class ExpertViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
