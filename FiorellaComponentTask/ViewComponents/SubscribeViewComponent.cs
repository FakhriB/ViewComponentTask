using Microsoft.AspNetCore.Mvc;

namespace FiorellaComponentTask.ViewComponents
{
    public class SubscribeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
