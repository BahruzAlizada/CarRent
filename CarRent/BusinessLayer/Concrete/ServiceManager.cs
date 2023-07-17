using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public Task TAddAsync(Service item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Service item)
        {
            throw new NotImplementedException();
        }

        public Task<Service> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Service>> TGetListAsync()
        {
           return await _serviceDal.GetListAsync();
        }

        public Task<Service> TGetOneNoFilterAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Service item)
        {
            throw new NotImplementedException();
        }
    }
}
