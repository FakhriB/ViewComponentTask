using Microsoft.AspNetCore.Mvc;
namespace FiorellaComponentTask.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
