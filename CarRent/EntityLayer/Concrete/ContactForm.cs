using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactForm
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name can not be null")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email can not be null")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Subject can not be null")]
        public string Subject { get; set; }
        [Required(ErrorMessage ="Message can not be null")]
        public string Message { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow.AddHours(4);

    }
}
