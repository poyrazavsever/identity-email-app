using Microsoft.AspNetCore.Mvc;

namespace IdentityEmailProject.Controllers
{
    public class MessageLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
