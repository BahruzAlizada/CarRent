using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFMarkaDal : GenericRepository<TransportMarka>, IMarkaDal
    {
        public async Task Activity(int? id)
        {
            using var c = new Context();

            if (id == null)
                return;
            TransportMarka marka = await c.TransportMarkas.FirstOrDefaultAsync(x=>x.Id == id);
            if(marka == null)
                return;
               
            if (marka.IsDeactive)
                marka.IsDeactive = false;
            else
                marka.IsDeactive = true;
            await c.SaveChangesAsync();
        }

        public async Task<List<TransportMarka>> GetMarkaListAsync()
        {
            using var c = new Context();
            return await c.Set<TransportMarka>().Include(x=>x.Children).ToListAsync();
        }
    }
}
