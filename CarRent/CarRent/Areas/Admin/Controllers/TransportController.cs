using BusinessLayer.Abstract;
using CarRent.Helpers;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TransportController : Controller
    {
        private readonly ICarService _carService;
        private readonly IWebHostEnvironment _env;
        public TransportController(ICarService carService,IWebHostEnvironment env)
        {
            _carService = carService;
            _env = env;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Transport> cars = await _carService.TGetCarListAsync();
            return View(cars);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create()
        {
            #region Get
            using var c = new Context();
            ViewBag.Markas = await c.TransportMarkas.Where(x => !x.IsDeactive && x.IsMain).ToListAsync();
            ViewBag.Bans = await c.TransportBans.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.Years = await c.TransportYears.OrderByDescending(x => x.Year).ToListAsync();
            ViewBag.Colors = await c.TransportColors.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.Motors = await c.TransportMotors.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.CountryMarket = await c.TransportCountryMarkets.ToListAsync();
            ViewBag.Engines = await c.TransportEngines.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.Seats = await c.TransportNumberSeats.ToListAsync();
            ViewBag.Advantages = await c.Advantages.Where(x => !x.IsDeactive).ToListAsync();

            TransportMarka firstMainMarka = await c.TransportMarkas.Include(x => x.Children).FirstOrDefaultAsync(x => x.IsMain);
            ViewBag.ChildMarka = firstMainMarka.Children;
            #endregion

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Transport car, int markaId, int banId,int yearId,int colorId,int motorId,
            int countryarketId,int seatId,int engineId,int childMarkaId, int[] advantageId)
        {
            #region Get
            using var c = new Context();
            ViewBag.Markas = await c.TransportMarkas.Where(x => !x.IsDeactive && x.IsMain).ToListAsync();
            ViewBag.Bans = await c.TransportBans.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.Years = await c.TransportYears.OrderByDescending(x => x.Year).ToListAsync();
            ViewBag.Colors = await c.TransportColors.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.Motors = await c.TransportMotors.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.CountryMarket = await c.TransportCountryMarkets.ToListAsync();
            ViewBag.Engines = await c.TransportEngines.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.Seats = await c.TransportNumberSeats.ToListAsync();
            ViewBag.Advantages = await c.Advantages.Where(x => !x.IsDeactive).ToListAsync();

            TransportMarka firstMainMarka = await c.TransportMarkas.Include(x=>x.Children).FirstOrDefaultAsync(x => x.IsMain);
            ViewBag.ChildMarka = firstMainMarka.Children;
            #endregion

            #region Relations
            car.TransportMarkaId = markaId;
            car.TransportBanId = banId;
            car.TransportYearId = yearId;
            car.TransportColorId = colorId;
            car.TransportMotorId=motorId;
            car.CountryMarketId = countryarketId;
            car.TransportEngineId = engineId;
            car.CarNumberSeatId = seatId;
            #endregion

            if (car.DailyPrice >= 150)
                car.VIP = true;
            else
                car.VIP = false;

            #region Image
            List<TransportImages> carImages = new List<TransportImages>();
            foreach (IFormFile Photo in car.Photos)
            {
                if (!Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Select image type");
                    return View();
                }
                if (Photo.IsOlder256Kb())
                {
                    ModelState.AddModelError("Photo", "Max 256Kb");
                    return View();
                }
                string folder = Path.Combine(_env.WebRootPath, "img");
                TransportImages carImage = new TransportImages
                {
                    Image = await Photo.SaveFileAsync(folder),
                };

                carImages.Add(carImage);
            }
            car.TransportImages = carImages;
            #endregion

            #region Advantage
            List<TransportAdvantage> transportAdvantages = new List<TransportAdvantage>();
            foreach (var item in advantageId)
            {
                TransportAdvantage transport = new TransportAdvantage
                {
                   AdvantageId=item,
                };
                transportAdvantages.Add(transport);
            }
            car.TransportAdvantages=transportAdvantages;
            #endregion

            await _carService.TAddAsync(car);
            return RedirectToAction("Index");
        }
        #endregion

        public async Task<IActionResult> LoadChild(int markaId)
        {
            using var c = new Context();
            List<TransportMarka> children = await c.TransportMarkas.Where(x=>x.ParentId==markaId).ToListAsync();
            return PartialView("_loadModelPartial",children);
        }
    }
}
