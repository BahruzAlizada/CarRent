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
    public class ContactFormManager : IContactFormService
    {
        IContactFormDal _contactFormDal;
        public ContactFormManager(IContactFormDal contactFormDal)
        {
            _contactFormDal = contactFormDal;   
        }
        public async Task TAddAsync(ContactForm item)
        {
            await _contactFormDal.InsertAsync(item);
        }

        public void TDelete(ContactForm item)
        {
            throw new NotImplementedException();
        }

        public Task<ContactForm> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactForm>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ContactForm> TGetOneNoFilterAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(ContactForm item)
        {
            throw new NotImplementedException();
        }
    }
}
