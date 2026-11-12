using Microsoft.AspNetCore.Mvc;

namespace IdentityEmailProject.ViewComponents.MessageLayoutViewComponents
{
    public class _MessageLayoutStyleComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
