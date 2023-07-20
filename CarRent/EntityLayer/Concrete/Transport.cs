using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Transport 
    {
            public int Id { get; set; }
            public TransportMarka TransportMarka { get; set; }
            public int TransportMarkaId { get; set; }
            public TransportBan TransportBan { get; set; }
            public int TransportBanId { get; set; }
            public TransportMotor TransportMotor { get; set; }
            public int TransportMotorId { get; set; }
            public TransportYear TransportYear { get; set; }
            public int TransportYearId { get; set; }
            public TransportColor TransportColor { get; set; }
            public int TransportColorId { get; set; }
            public TransportCountryMarket CountryMarket { get; set; }
            public int CountryMarketId { get; set; }
            public TransportEngine TransportEngine { get; set; } //-
            public int TransportEngineId { get; set; }
            public TransportNumberSeats CarNumberSeat { get; set; } //-
            public int CarNumberSeatId { get; set; }
            public double DailyPrice { get; set; }
            public double KM { get; set; }
            public bool Automathic { get; set; }
            public bool VIP { get; set; }
            public bool Featured { get; set; }
            public bool IsAccident { get; set; }
            public bool IsDeactive { get; set; }
            
            public TransportDetail TransportDetail { get; set; }
            //public List<TransportCustomer> TransportCustomers { get; set; }
            public List<TransportImages> TransportImages { get; set; }
            public List<TransportAdvantage> TransportAdvantages { get; set; }
            [NotMapped]
            public IFormFile[] Photos { get; set; }
        }
    }

