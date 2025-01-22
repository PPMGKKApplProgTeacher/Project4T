using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4T.Core.IServices;
using Project4T.Models;

namespace Project4T.Core.Services
{
    public class OrderProductService : IOrderProductService
    {
        public void Add(OrderProduct orderProduct)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderProduct GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderProduct> GetOrdersByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetProductOrders(int productId)
        {
            throw new NotImplementedException();
        }

        public List<OrderProduct> GetProductsByOrderId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
