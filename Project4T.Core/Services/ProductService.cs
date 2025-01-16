using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4T.Core.IServices;
using Project4T.Core.Validators;
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
        private static bool ValidateProduct(Product product)
        {
            if (!ProductValidator.Validate(product.Name, product.Price))
            {
                return false;
            }
            else if (!CategoryValidator.CategoryExists(product.CategoryId))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        public void Add(Product product)
        {
            if (!ValidateProduct(product))
            {
                throw new ArgumentException("Validation didn't pass!");
            }
            _repo.Add(product);
        }

        public Product GetById(int id)
        {
            if (_repo.)
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
