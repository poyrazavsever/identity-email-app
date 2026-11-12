using Microsoft.AspNetCore.Mvc;

namespace IdentityEmailProject.ViewComponents.MessageLayoutViewComponents
{
    public class _MessageLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
