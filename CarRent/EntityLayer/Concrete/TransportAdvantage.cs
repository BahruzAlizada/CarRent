using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TransportAdvantage
    {
        public int Id { get; set; }
        public Transport Transport { get; set; }
        public int TransportId { get; set; }
        public Advantage Advantage { get; set; }
        public int AdvantageId { get; set; }
       
    }
}
