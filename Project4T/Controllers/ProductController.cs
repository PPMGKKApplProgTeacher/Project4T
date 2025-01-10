using Microsoft.AspNetCore.Mvc;

namespace Project4T.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
