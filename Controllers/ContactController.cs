using Microsoft.AspNetCore.Mvc;


namespace süleyman.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
