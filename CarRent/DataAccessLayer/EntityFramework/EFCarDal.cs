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
    public class EFCarDal : GenericRepository<Car>, ICarDal
    {
        public async Task<Car> CarDetailAsync(int? id)
        {
            using var c = new Context();
            return await c.Set<Car>().Include(x => x.CarDetail).
                Include(x=>x.Marka).Include(x=>x.Ban).Include(x=>x.CarImages).
                ThenInclude(x=>x.Image).FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<List<Car>> GetCarListAsync()
        {
            using var c= new Context();
            return await c.Set<Car>().Where(x=>!x.IsDeactive).Include(x => x.Ban).Include(x => x.Marka).
                Include(x => x.CarImages).ThenInclude(x => x.Image).OrderByDescending(x => x.Id).ToListAsync();
        }
    }
}
