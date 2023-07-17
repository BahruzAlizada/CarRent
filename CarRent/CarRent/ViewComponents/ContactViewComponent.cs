using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarRent.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly IContactInfoService _contactInfoService;
        public ContactViewComponent(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ContactInfo contactInfo = await _contactInfoService.TGetOneNoFilterAsync();
            return View(contactInfo);
        }
    }
}
