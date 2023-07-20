using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Advantage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TransportAdvantage> CarAdvantages { get; set; }
        public bool IsDeactive { get; set; }
    }
}
