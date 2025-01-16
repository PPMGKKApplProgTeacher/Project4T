using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Project4T.Core.IServices;
using Project4T.Core.Validators;
using Project4T.DataAccess.Repository;
using Project4T.Models;

namespace Project4T.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repo;
        //private readonly IRepository<Product> _prodRepo;

        public CategoryService(IRepository<Category> repo)
        {
            this._repo = repo;
        }

        public void Add(Category category)
        {
            if (CategoryValidator.ValidateInput(category.Name))
            {
                _repo.Add(category);
            }
            else
            {
                throw new ArgumentException("The category already exists!");
            }
        }

        public void Delete(int id)
        {
            if (CategoryValidator.CategoryExist(id))
            {
                _repo.Delete(id);
            }
            else
            {
                throw new ArgumentException("The category already exists!");
            }
            
        }
        // maybe delete
        public List<Category> Find(Expression<Func<Category, bool>> filter)
        {
            return _repo.Find(filter);
        }

        public List<Category> GetAll()
        {
            return _repo.GetAll().ToList();
        }

        public Category GetById(int id)
        {
           return _repo.Get(id);
        }

        public Category GetProductCategory(int productId)
        {
            // Product prod = _prodRepo.Get(productId);
            // return _repo.Find(c => c.Products.Contains(prod)).First();
            // needs to be checked
            return _repo.Find(x => x.Products.Any(p => p.Id == productId)).FirstOrDefault();
            
        }

        public void Update(Category category)
        {
            if (!CategoryValidator.CategoryExist(category.Id))
            {
                throw new ArgumentException("The category is not valid!");
            }
            _repo.Update(category);
        }
    }
}
