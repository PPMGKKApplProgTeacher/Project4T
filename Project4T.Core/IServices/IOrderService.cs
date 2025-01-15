using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4T.Models;

namespace Project4T.Core.IServices
{
    public interface IOrderService
    {
        // Добавя нова поръчка
        void Add(Order order);
        // Записва информация за поръчка при промяна
        void Update(Order order);
        // Изтрива поръчка по id
        void Delete(int id);
        // Връща поръчка по id
        Order GetById(int id);
        // Връща списък от всички поръчки
        List<Order> GetAll();
        // Връща списък от поръчки по id на продукт
        List<Order> GetProductOrders(int productId);

    }
}
