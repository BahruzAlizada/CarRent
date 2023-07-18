using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CarColor
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public List<Car> Cars { get; set; }
        public bool IsDeactive { get; set; }

    }
}
