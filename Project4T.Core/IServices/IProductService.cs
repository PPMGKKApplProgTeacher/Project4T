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
        Product GetById(int id);
        void Add(Product product);
        public List<Product> GetProductByCategory(int categoryId);
    }
}
