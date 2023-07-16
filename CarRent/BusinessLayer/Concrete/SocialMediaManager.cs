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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public Task TAddAsync(SocialMedia item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SocialMedia item)
        {
            throw new NotImplementedException();
        }

        public Task<SocialMedia> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SocialMedia>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<SocialMedia> TGetOneNoFilterAsync()
        {
            return await _socialMediaDal.GetOneNoFilterAsync();
        }

        public Task TUpdateAsync(SocialMedia item)
        {
            throw new NotImplementedException();
        }
    }
}
