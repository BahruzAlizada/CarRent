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
    public class BioManager : IBioService
    {
        IBioDal _bioDal;
        public BioManager(IBioDal bioDal)
        {
            _bioDal=bioDal;
        }
        public Task TAddAsync(Bio item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Bio item)
        {
            throw new NotImplementedException();
        }

        public Task<Bio> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Bio>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Bio> TGetOneNoFilterAsync()
        {
            return await _bioDal.GetOneNoFilterAsync();
        }

        public Task TUpdateAsync(Bio item)
        {
            throw new NotImplementedException();
        }
    }
}
