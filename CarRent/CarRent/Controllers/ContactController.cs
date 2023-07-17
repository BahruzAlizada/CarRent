using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarRent.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactFormService _contactFormService;
        public ContactController(IContactFormService contactFormService)
        {
            _contactFormService = contactFormService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Index(ContactForm form)
        {
            await _contactFormService.TAddAsync(form);
            return RedirectToAction("Index");
        }
    }
}
