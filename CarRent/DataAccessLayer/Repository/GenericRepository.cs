using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public  void Delete(T item)
        {
            using var c = new Context();
            c.Remove(item);
            c.SaveChanges();
        }

        public async Task<List<T>> GetListAsync()
        {
            using var c = new Context();
            return await c.Set<T>().ToListAsync();
        }

        public async Task InsertAsync(T item)
        {
            using var c = new Context();
            await c.AddAsync(item);
            await c.SaveChangesAsync();
        }

        public async Task UpdateAsync(T item)
        {
            using var c = new Context();
            c.Update(item);
            await c.SaveChangesAsync();
        }

        public async Task<T> GetOneNoFilterAsync()
        {
            using var c = new Context();
            return await c.Set<T>().FirstOrDefaultAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            using var c = new Context();
            return await c.Set<T>().FindAsync(id);
        }
    }
}
