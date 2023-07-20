using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMarkaDal : IGenericDal<TransportMarka>
    {
        Task<List<TransportMarka>> GetMarkaListAsync();
        Task Activity(int? id);
    }
}
