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
    public class MarkaManager : IMarkaService
    {
        IMarkaDal _markaDal;
        public MarkaManager(IMarkaDal markaDal)
        {
            _markaDal=markaDal;
        }
        public Task TAddAsync(Marka item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Marka item)
        {
            throw new NotImplementedException();
        }

        public Task<Marka> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Marka>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Marka> TGetOneNoFilterAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Marka item)
        {
            throw new NotImplementedException();
        }
    }
}
