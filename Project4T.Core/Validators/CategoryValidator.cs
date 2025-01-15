using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4T.DataAccess.Repository;
using Project4T.Models;

namespace Project4T.Core.Validators
{
    public static class CategoryValidator
    {
        private static IRepository<Category> repo;
        public static bool CategoryExist(int id)
        {
            if (repo.Get(id) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
