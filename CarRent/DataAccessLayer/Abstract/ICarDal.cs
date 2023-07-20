using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICarDal : IGenericDal<Transport>
    {
        Task<Transport> CarDetailAsync(int? id);
        Task<List<Transport>> GetCarListAsync();
    }
}
