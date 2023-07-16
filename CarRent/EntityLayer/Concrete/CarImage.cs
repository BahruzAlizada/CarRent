﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CarImage
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public Image Image { get;set; }
        public int ImageId { get; set; }
    }
}
