using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        Task InsertAsync(T item);
        void Delete(T item);
        Task UpdateAsync(T item);
        Task<T> GetOneNoFilterAsync();
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetListAsync();

    }
}
