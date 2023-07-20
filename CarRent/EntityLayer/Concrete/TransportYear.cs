using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TransportYear
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public List<Transport> Transports { get; set; }
    }
}
