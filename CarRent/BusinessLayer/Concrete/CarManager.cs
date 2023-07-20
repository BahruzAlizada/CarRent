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
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public async Task TAddAsync(Transport item)
        {
            await _carDal.InsertAsync(item);
        }

        public Task<Transport> TCarDetailAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Transport item)
        {
            throw new NotImplementedException();
        }

        public Task<Transport> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Transport>> TGetCarListAsync()
        {
            return await _carDal.GetCarListAsync();
        }

        public Task<List<Transport>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Transport> TGetOneNoFilterAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Transport item)
        {
            throw new NotImplementedException();
        }
    }
}
