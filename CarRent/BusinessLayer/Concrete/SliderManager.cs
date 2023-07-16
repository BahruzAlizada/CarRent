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
    internal class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public Task TAddAsync(Slider item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Slider item)
        {
            throw new NotImplementedException();
        }

        public Task<Slider> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Slider>> TGetListAsync()
        {
            return await _sliderDal.GetListAsync();
        }

        public Task<Slider> TGetOneNoFilterAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Slider item)
        {
            throw new NotImplementedException();
        }
    }
}
