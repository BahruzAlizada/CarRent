using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TransportNumberSeats
    {
        public int Id { get; set; }
        public string SeatNumber { get; set; }
        public List<Transport> Cars { get; set; }
    }
}
