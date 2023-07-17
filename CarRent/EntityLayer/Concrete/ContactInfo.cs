using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string HeadOfficeAddress { get; set; }
        public string BranchOfficeAddress { get; set; }
        [DataType(DataType.EmailAddress)]
        public string CustomerServiceEmail { get; set; }
        [DataType(DataType.EmailAddress)]
        public string ReturnRefundEmail { get; set; }
    }
}
