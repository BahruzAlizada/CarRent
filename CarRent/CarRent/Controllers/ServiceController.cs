using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public async Task<IActionResult> Index()
        {
            List<Service> services = await _serviceService.TGetListAsync();
            List<Service> servicelimit=services.Where(x=>!x.IsDeactive).OrderByDescending(x=>x.Id).ToList();
            return View(servicelimit);
        }
    }
}
