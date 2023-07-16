using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Image
    {
        public int Id { get; set; }
        public string Images { get; set; }
        public List<CarImage> CarImages { get; set; }
    }
}
