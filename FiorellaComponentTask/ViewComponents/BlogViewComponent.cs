using Microsoft.AspNetCore.Mvc;

namespace FiorellaComponentTask.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
