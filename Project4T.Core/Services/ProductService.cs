using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4T.Core.IServices;
using Project4T.DataAccess.Repository;
using Project4T.Models;

namespace Project4T.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repo;
        public ProductService(IRepository<Product> repo) 
        {
            this._repo = repo;
        }


        public List<Product> GetProductByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
