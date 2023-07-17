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
        public Task TAddAsync(Car item)
        {
            throw new NotImplementedException();
        }

        public Task<Car> TCarDetailAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Car item)
        {
            throw new NotImplementedException();
        }

        public Task<Car> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Car>> TGetCarListAsync()
        {
            return await _carDal.GetCarListAsync();
        }

        public Task<List<Car>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Car> TGetOneNoFilterAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Car item)
        {
            throw new NotImplementedException();
        }
    }
}
