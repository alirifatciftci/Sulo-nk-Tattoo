using Microsoft.AspNetCore.Mvc;

namespace süleyman.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
    }
}
