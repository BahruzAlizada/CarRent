using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        Task TAddAsync(T item);
        void TDelete(T item);
        Task TUpdateAsync(T item);
        Task<List<T>> TGetListAsync();
        Task<T> TGetByIdAsync(int id);
        Task<T> TGetOneNoFilterAsync();
    }
}
