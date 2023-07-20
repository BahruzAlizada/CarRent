using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-OK3QKVJ;database=CarRent;integrated security=true;");
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Logo> Logos { get; set; }
        public DbSet<Bio> Bios { get; set; }


        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }


        public DbSet<TransportMarka> TransportMarkas { get; set; }
        public DbSet<TransportBan> TransportBans { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<TransportMotor> TransportMotors { get; set; }
        public DbSet<TransportYear> TransportYears { get; set; }
        public DbSet<TransportColor> TransportColors { get; set; }
        public DbSet<TransportDetail> TransportDetails { get; set; }
        public DbSet<TransportImages> TransportImages { get; set; }
        public DbSet<TransportCountryMarket> TransportCountryMarkets { get; set; }
        public DbSet<TransportEngine> TransportEngines { get; set; }
        public DbSet<Advantage> Advantages { get; set; }
        public DbSet<TransportAdvantage> TransportAdvantages { get; set; }
        public DbSet<TransportNumberSeats> TransportNumberSeats { get; set; }

    }

}
