using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Project4T.DataAccess.Repository;
using Project4T.Models;


namespace Project4T.Core.IServices
{
    public interface IProductService
    {
        // връща продукт по зададено id
        Product GetById(int id);
        // добавя продукт
        void Add(Product product);
        // Връща списък от продукти по категория
        public List<Product> GetProductsByCategory(int categoryId);
        // Записва информацията за продукт при промяна
        void Update(Product product);
        // Изтрива продукт по зададено id
        void Delete(int id);
        // Връща всички продукти
        List<Product> GetAll();
        // Търси продукт по зададено критерии
        List<Product> Find(Expression<Func<Product, bool>> filter);
    }
}
