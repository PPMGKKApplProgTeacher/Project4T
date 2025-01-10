using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4T.Models;


namespace Project4T.Core.IServices
{
    public interface IProductService
    {
        public List<Product> GetProductByCategory(int categoryId);
    }
}
