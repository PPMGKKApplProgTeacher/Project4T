using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project4T.Models
{
    public class ProductFilterViewModel
    {
        public int? CategoryId { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal? MinPrice { get; set; }
        public string? Search {  get; set; }    
        public SelectList Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
