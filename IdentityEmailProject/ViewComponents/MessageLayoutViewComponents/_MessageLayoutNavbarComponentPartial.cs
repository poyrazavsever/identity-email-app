using Microsoft.AspNetCore.Mvc;

namespace IdentityEmailProject.ViewComponents.MessageLayoutViewComponents
{
    public class _MessageLayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
