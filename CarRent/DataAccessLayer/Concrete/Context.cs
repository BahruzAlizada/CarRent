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


        public DbSet<Marka> Markas { get; set; }
        public DbSet<Ban> Bans { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarMotor> CarMotors { get; set; }
        public DbSet<CarYear> CarYears { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<CarDetail> CarDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarCustomer> CarCustomers { get; set; }
        public DbSet<CarImages> CarImagess { get; set; }
        public DbSet<CarCountryMarket> CarCountryMarkets { get; set; }
        
    }
}
