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

        public async Task TActivity(int? id)
        {
            await _banDal.Activity(id);
        }

        public async Task TAddAsync(Ban item)
        {
            await _banDal.InsertAsync(item);
        }

        public void TDelete(Ban item)
        {
            throw new NotImplementedException();
        }

        public async Task<Ban> TGetByIdAsync(int id)
        {
            return await _banDal.GetByIdAsync(id);
        }

        public async Task<List<Ban>> TGetListAsync()
        {
            return await _banDal.GetListAsync();
        }

        public Task<Ban> TGetOneNoFilterAsync()
        {
            throw new NotImplementedException();
        }

        public async Task TUpdateAsync(Ban item)
        {
            await _banDal.UpdateAsync(item);
        }
    }
}
