using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        public string InstgramLink { get; set; }
        public string FacebookLink { get; set; }
        public string TvitterLink { get; set; }
        public string YoutbeLink { get; set; }
    }
}
