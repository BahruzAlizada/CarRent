using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Car
    {
        public int Id { get; set; }
        public Marka Marka { get; set; }
        public int MarkaId { get; set; }
        public Ban Ban { get; set; }
        public int BanId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public double KM { get; set; }
        public bool Automathic { get; set; }
        public bool Benzin { get; set; }
        public bool VIP { get; set; }
        public bool Featured { get; set; }
        public bool IsDeactive { get; set; }
        public CarDetail CarDetail { get; set; }
        public List<CarImage> CarImages { get; set; }
        public List<CarCustomer> CarCustomers { get; set; }
    }
}
