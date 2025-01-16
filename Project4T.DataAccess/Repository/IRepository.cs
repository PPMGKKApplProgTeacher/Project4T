using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4T.DataAccess.Repository
{
    public interface IRepository <T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T Get(int id);
        List<T> GetAll();
    }
}
