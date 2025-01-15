using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4T.DataAccess.Repository;
using Project4T.Models;

namespace Project4T.Core.Validators
{
    public class OrderProductValidator
    {
        private static IRepository<OrderProduct> _repo;
        public  static bool Validate(int quantity)
        {
            if(quantity<=0)
            {
                return false;
            }
            return true;
        }

    }
}
