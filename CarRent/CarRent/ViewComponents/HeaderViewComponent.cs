using BusinessLayer.Abstract;
using CarRent.ViewModels;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarRent.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IBioService _bioService;
        private readonly ISocialMediaService _socialMediaService;
        public HeaderViewComponent(IBioService bioService,ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
            _bioService= bioService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            BioSMediaVM bioSMedia = new BioSMediaVM
            {
                Bio = await _bioService.TGetOneNoFilterAsync(),
                SocialMedia = await _socialMediaService.TGetOneNoFilterAsync()
            };
            return View(bioSMedia);
        }
    }
}
