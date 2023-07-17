﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        Task<Car> TCarDetailAsync(int? id);
        Task<List<Car>> TGetCarListAsync();
    }
}
