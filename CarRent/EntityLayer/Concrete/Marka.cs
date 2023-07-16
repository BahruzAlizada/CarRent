using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Marka
    {
        public int Id { get; set; }
        public string MarkaName { get; set; }
        public List<Car> Cars;
        public bool IsDeactive { get; set; }
    }
}
