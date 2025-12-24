using Microsoft.AspNetCore.Mvc;

namespace FiorellaComponentTask.ViewComponents
{
    public class InstagramViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
