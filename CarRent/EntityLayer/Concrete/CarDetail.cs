using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CarDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}
