using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CarMotor
    {
        public int Id { get; set; }
        public double Motor { get; set; }
        public List<Car> Cars { get; set; }
        public bool IsDeactive { get; set; }
    }
}
