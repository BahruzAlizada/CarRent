using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TransportMarka
    {
        public int Id { get; set; }
        public string MarkaName { get; set; }
        public bool IsMain { get; set; }
        public List<TransportMarka> Children { get; set; }
        public TransportMarka Parent { get; set; }
        public int? ParentId { get; set; }
        public List<Transport> Transports;
        public bool IsDeactive { get; set; }
    }
}
