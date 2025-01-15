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
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repo;

        public OrderService(IRepository<Order> repo)
        {
            _repo = repo;
        }
        public void Add(Order order)
        {
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetProductOrders(int productId)
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
