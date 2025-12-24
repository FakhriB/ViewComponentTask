using Microsoft.AspNetCore.Mvc;

namespace FiorellaComponentTask.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
