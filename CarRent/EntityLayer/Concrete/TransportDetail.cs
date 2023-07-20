using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TransportDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Transport Transport { get; set; }
        public int TransportId { get; set; }
    }
}
