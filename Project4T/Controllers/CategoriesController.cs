using Microsoft.AspNetCore.Mvc;
using Project4T.Core.IServices;
using Project4T.Core.Services;

namespace Project4T.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var element = _categoryService.GetAll();
            return View(element);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
