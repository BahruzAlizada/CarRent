using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.ViewComponents
{
    public class LogoViewComponent : ViewComponent
    {
        private readonly ILogoService _logoService;
        public LogoViewComponent(ILogoService logoService)
        {
            _logoService= logoService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Logo> logo = await _logoService.TGetListAsync();
            List<Logo> logolimit = logo.Where(x=>!x.IsDeactive).ToList();
            return View(logolimit);
        }
    }
}
