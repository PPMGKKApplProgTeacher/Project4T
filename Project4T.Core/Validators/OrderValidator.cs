using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4T.DataAccess.Repository;
using Project4T.Models;

namespace Project4T.Core.Validators
{
    public class OrderValidator
    {
        private static IRepository<Order> _repo;
        
        public static bool ValidateInput(DateTime date)
        {
            if (date>DateTime.Now)
            {
                return false;             
            }
            return true;
        }
        public static bool OrderExist(int id)
        {
            if(_repo.Get(id) == null)
            {
                return false;
            }
            return true;
        }
    }
}
