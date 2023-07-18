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

        public async Task TActivity(int? id)
        {
            await _markaDal.Activity(id);
        }

        public async Task TAddAsync(Marka item)
        {
            await _markaDal.InsertAsync(item);
        }

        public void TDelete(Marka item)
        {
            throw new NotImplementedException();
        }

        public async Task<Marka> TGetByIdAsync(int id)
        {
            return await _markaDal.GetByIdAsync(id);
        }

        public async Task<List<Marka>> TGetListAsync()
        {
            return await _markaDal.GetListAsync();
        }

        public Task<Marka> TGetOneNoFilterAsync()
        {
            throw new NotImplementedException();
        }

        public async Task TUpdateAsync(Marka item)
        {
            await _markaDal.UpdateAsync(item);
        }
    }
}
