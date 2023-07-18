﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CarEngine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
        public bool IsDeactive { get; set; }
    }
}
