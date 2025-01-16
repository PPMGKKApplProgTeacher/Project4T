using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project4T.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            this.dbSet=_context.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                _context.SaveChanges();
            }
            else 
            {
                throw new ArgumentException("No model with that id.");
            }
        }
        public T Get(int id)
        {
            var entity = dbSet.Find(id);
            if (entity == null)
            {
                throw new ArgumentException("No model with that id");
            }
            return entity;
        }

        public List<T> GetAll()
        {
            var entities = dbSet.ToList();
            return entities;
        }
        public void Update(T entity)
        {
            dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
