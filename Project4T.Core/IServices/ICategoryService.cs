using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Project4T.Models;

namespace Project4T.Core.IServices
{
    public interface ICategoryService
    {
        // Добавя нова категория
        void Add(Category category);
        // Записва информация за кетегорията при промяна
        void Update(Category category);
        // Изтрива категория по id
        void Delete(int id);
        // Връща категория по id
        Category GetById(int id);
        // Връща списък от всички категории
        List<Category> GetAll();
        // Връща категория по id на продукт
        Category GetProductCategory(int productId);
        // Търси категория по зададен критерий
        List<Category> Find(Expression<Func<Category, bool>> filter);
    }
}
