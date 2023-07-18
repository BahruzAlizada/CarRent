using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBanDal : GenericRepository<Ban>, IBanDal
    {
        public async Task Activity(int? id)
        {
            using var c = new Context();
            if (id == null) return;
            Ban ban = await c.Bans.FirstOrDefaultAsync(x => x.Id == id);
            if (ban == null) return;

            if (ban.IsDeactive)
                ban.IsDeactive = false;
            else
                ban.IsDeactive = true;

            await c.SaveChangesAsync();
        }
    }
}
