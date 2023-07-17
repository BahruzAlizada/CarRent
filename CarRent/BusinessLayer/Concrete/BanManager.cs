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
    public class BanManager : IBanService
    {
        IBanDal _banDal;
        public BanManager(IBanDal banDal)
        {
            _banDal = banDal;
        }
        public Task TAddAsync(Ban item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Ban item)
        {
            throw new NotImplementedException();
        }

        public Task<Ban> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ban>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Ban> TGetOneNoFilterAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Ban item)
        {
            throw new NotImplementedException();
        }
    }
}
