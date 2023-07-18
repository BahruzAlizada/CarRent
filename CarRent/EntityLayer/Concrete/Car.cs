using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public CarMotor CarMotor { get; set; }
        public int CarMotorId { get; set; }
        public CarYear CarYear { get; set; }
        public int CarYearId { get; set; }
        public CarColor CarColor { get; set; }
        public int CarColorId { get; set; }
        public CarCountryMarket CountryMarket { get; set; }
        public int CountryMarketId { get; set; }

        public double DailyPrice { get; set; }
        public double KM { get; set; }
        public bool Automathic { get; set; }
        public bool Benzin { get; set; }
        public bool VIP { get; set; }
        public bool Featured { get; set; }
        public bool IsAccident { get; set; }
        public bool IsDeactive { get; set; }
        public CarDetail CarDetail { get; set; }
        public List<CarCustomer> CarCustomers { get; set; }
        public List<CarImages> CarImages { get; set; }
        [NotMapped]
        public IFormFile[] Photos { get; set; }
    }
}
