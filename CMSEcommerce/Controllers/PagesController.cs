using Microsoft.AspNetCore.Mvc;

namespace CMSEcommerce.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index(string slug = "")
        {
            return View("Index", slug);
        }
    }
}
