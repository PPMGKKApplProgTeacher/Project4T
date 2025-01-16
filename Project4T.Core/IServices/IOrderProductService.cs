using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4T.Models;

namespace Project4T.Core.IServices
{
    public interface IOrderProductService
    {
        // Добавя продукт към поръчката
        void Add(OrderProduct orderProduct);
        // Изтрива продукт от поръчка
        void Delete(int id);
        // Връща релация по id
        OrderProduct GetById(int id);
        // Връща списък от всички релации
        List<OrderProduct> GetAll();
        // Връща списък от поръчки по id на продукт
        List<OrderProduct> GetOrdersByProductId(int id);
        // Връща списък от продукти по id на поръчка
        List<OrderProduct> GetProductsByOrderId(int id);
        List<Order> GetProductOrders(int productId);
    }
}
