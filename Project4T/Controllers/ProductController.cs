using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project4T.Core.IServices;
using Project4T.Core.Services;
using Project4T.Models;

namespace Project4T.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService  productService, 
                                 ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index(ProductFilterViewModel? filter)
        {
            var query = _productService.GetAll().AsQueryable();
            if (filter != null && filter.CategoryId != null) 
            {
                 query = query.Where(x=>x.CategoryId==filter.CategoryId.Value);
            }
            if (filter != null && filter.MinPrice != null) 
            {
                query = query.Where(x=>x.Price>=filter.MinPrice.Value);
            }
            if (filter != null && filter.MaxPrice != null)
            {
                query = query.Where(x=>x.Price<=filter.MaxPrice.Value);
            }
            var model = new ProductFilterViewModel
            {
                CategoryId = filter.CategoryId,
                MinPrice = filter.MinPrice,
                MaxPrice = filter.MaxPrice,
                Categories = new SelectList(_categoryService.GetAll(), "CategoryId", "Name"),
                Products = query.Include(x => x.Category).ToList()
            };
            return View(model);
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
