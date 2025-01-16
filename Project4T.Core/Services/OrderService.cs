using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Project4T.Core.IServices;
using Project4T.Core.Validators;
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
        public bool ValidateOrder(Order order)
        {
            foreach (var item in order.Products)
            {
                if (!ProductValidator.ProductExists(item.Id))
                {
                    return false;
                }
            }
            if (!OrderValidator.ValidateInput(order.OrderDate))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Add(Order order)
        {
            if (ValidateOrder(order) == true)
            {
                _repo.Add(order);
            }
            else 
            {
                throw new ArgumentException("Validation didn't pass!");
            }
        }

        public void Delete(int id)
        {
            if (OrderValidator.OrderExist(id))
            {
                _repo.Delete(id);
            }
            else
            {
                throw new ArgumentException("This order doesn't exist.");
            }
        }

        public List<Order> GetAll()
        {
            return _repo.GetAll();
        }

        public Order GetById(int id)
        {
            return _repo.Get(id);
        }
        public void Update(Order order)
        {
            if (!ValidateOrder(order) )
            {
                throw new ArgumentException("Validation didn't pass!");
            }
            if (!OrderValidator.OrderExist(order.Id))
            {                                                                                    
                throw new ArgumentException("Order doesn't exist.");
            }
            else
            {
                _repo.Update(order);
            }
            
        }
    }
}
