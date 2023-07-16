using BusinessLayer.Abstract;
using CarRent.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarRent.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly IBioService _bioService;
        private readonly ISocialMediaService _socialMediaService;
        public FooterViewComponent(IBioService bioService,ISocialMediaService socialMediaService)
        {
            _bioService = bioService;
            _socialMediaService = socialMediaService;
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
