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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal= aboutDal;
        }

        public Task TAddAsync(About item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About item)
        {
            throw new NotImplementedException();
        }

        public Task<About> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<About>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<About> TGetOneNoFilterAsync()
        {
            return await _aboutDal.GetOneNoFilterAsync();
        }

        public Task TUpdateAsync(About item)
        {
            throw new NotImplementedException();
        }
    }
}
