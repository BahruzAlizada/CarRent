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
    public class ContactInfoManager : IContactInfoService
    {
        IContactInfoDal _contactInfoDal;
        public ContactInfoManager(IContactInfoDal contactInfoDal)
        {
            _contactInfoDal = contactInfoDal;
        }
        public Task TAddAsync(ContactInfo item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactInfo item)
        {
            throw new NotImplementedException();
        }

        public Task<ContactInfo> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactInfo>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ContactInfo> TGetOneNoFilterAsync()
        {
            return await _contactInfoDal.GetOneNoFilterAsync();
        }

        public Task TUpdateAsync(ContactInfo item)
        {
            throw new NotImplementedException();
        }
    }
}
