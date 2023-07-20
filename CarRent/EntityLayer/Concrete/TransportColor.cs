using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TransportColor
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public List<Transport> Transports { get; set; }
        public bool IsDeactive { get; set; }

    }
}
