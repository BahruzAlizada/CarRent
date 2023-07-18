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
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly IWebHostEnvironment _env;
        public CarController(ICarService carService,IWebHostEnvironment env)
        {
            _carService = carService;
            _env = env;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Car> cars = await _carService.TGetCarListAsync();
            return View(cars);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create()
        {
            using var c = new Context();
            ViewBag.Markas = await c.Markas.Where(x=>!x.IsDeactive).ToListAsync();
            ViewBag.Bans = await c.Bans.Where(x =>! x.IsDeactive).ToListAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Car car,int markaId,int banId)
        {
            using var c = new Context();
            ViewBag.Markas = await c.Markas.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.Bans = await c.Bans.Where(x => !x.IsDeactive).ToListAsync();

            #region Marka Ban VIP
            car.MarkaId = markaId;
            car.BanId = banId;

            if (car.Price >= 150)
                car.VIP = true;
            else
                car.VIP = false;
            #endregion

            #region Image
            List<CarImages> carImages = new List<CarImages>();
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
                CarImages carImage = new CarImages
                {
                    Image = await Photo.SaveFileAsync(folder),
                };

                carImages.Add(carImage);
            }
            car.CarImages = carImages;
            #endregion

            await _carService.TAddAsync(car);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
