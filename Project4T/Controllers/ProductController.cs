using Microsoft.AspNetCore.Mvc;
using Project4T.Core.IServices;
using Project4T.Core.Services;

namespace Project4T.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public IActionResult Index()
        {
            return View();
        }
    }
}
