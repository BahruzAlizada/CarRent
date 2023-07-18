using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MarkaController : Controller
    {
        private readonly IMarkaService _markaService;
        public MarkaController(IMarkaService markaService)
        {
            _markaService = markaService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Marka> marka = await _markaService.TGetListAsync();
            return View(marka);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Marka marka)
        {
            await _markaService.TAddAsync(marka);
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int id)
        {
            Marka dbmarka = await _markaService.TGetByIdAsync(id);
            if (dbmarka == null)
                return BadRequest();

            return View(dbmarka);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int id,Marka marka)
        {
            Marka dbmarka = await _markaService.TGetByIdAsync(id);
            if (dbmarka == null)
                return BadRequest();

            dbmarka.MarkaName = marka.MarkaName;

            await _markaService.TUpdateAsync(marka);
            return RedirectToAction("Index");
        }
        #endregion

        #region Activity
        public async Task<IActionResult> Activity(int? id)
        {
            await _markaService.TActivity(id); 
            return RedirectToAction("Index");
        }
        #endregion
    }
}
