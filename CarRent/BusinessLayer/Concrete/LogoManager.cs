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
    public class LogoManager : ILogoService
    {
        ILogoDal _logoDal;
        public LogoManager(ILogoDal logoDal)
        {
            _logoDal= logoDal;
        }
        public Task TAddAsync(Logo item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Logo item)
        {
            throw new NotImplementedException();
        }

        public Task<Logo> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Logo>> TGetListAsync()
        {
            return await _logoDal.GetListAsync();
        }

        public Task<Logo> TGetOneNoFilterAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Logo item)
        {
            throw new NotImplementedException();
        }
    }
}
