using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This column is not null")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This column is not null")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This column is not null")]
        public string PhoneNumber { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow.AddHours(4);
        public string SpecialRequest { get; set; }
        public List<CarCustomer> CarCustomers { get; set; }
    }
}
