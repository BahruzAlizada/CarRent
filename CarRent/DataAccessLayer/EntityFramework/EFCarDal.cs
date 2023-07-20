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
    public class EFCarDal : GenericRepository<Transport>, ICarDal
    {
        public async Task<Transport> CarDetailAsync(int? id)
        {
            using var c = new Context();
            return await c.Set<Transport>().Include(x => x.TransportDetail).
                Include(x=>x.TransportMarka).Include(x=>x.TransportBan).Include(x=>x.TransportImages)
                .FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<List<Transport>> GetCarListAsync()
        {
            using var c= new Context();
            return await c.Set<Transport>().Include(x => x.TransportBan).Include(x => x.TransportMarka).
                Include(x => x.TransportImages).Include(x=>x.TransportYear).Include(x=>x.TransportColor)
                .Include(x =>x.TransportMotor).Include(x=>x.CountryMarket).
                Include(x=>x.TransportDetail).Include(x=>x.TransportEngine).
                Include(x=>x.CarNumberSeat).Include(x=>x.TransportAdvantages).
                ThenInclude(x=>x.Advantage).OrderByDescending(x => x.Id).ToListAsync();
        }
    }
}
