using Microsoft.AspNetCore.Mvc;

namespace IdentityEmailProject.ViewComponents.MessageLayoutViewComponents
{
    public class _MessageLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
