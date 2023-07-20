using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
            List<TransportMarka> marka = await _markaService.TGetMarkaListAsync();
            List<TransportMarka> markalimit = marka.Where(x=>x.IsMain).ToList();
            return View(markalimit);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create()
        {
            var parentMarka = await _markaService.TGetListAsync();
            ViewBag.ParentMarka = parentMarka.Where(x => x.IsMain).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(TransportMarka marka,int? markaId)
        {
            var parentMarka = await _markaService.TGetListAsync();
            ViewBag.ParentMarka = parentMarka.Where(x => x.IsMain).ToList();

            if(!marka.IsMain)
            {
                marka.ParentId = markaId;
            }

            await _markaService.TAddAsync(marka);
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int id)
        {
            TransportMarka dbmarka = await _markaService.TGetByIdAsync(id);
            if (dbmarka == null)
                return BadRequest();

            return View(dbmarka);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int id, TransportMarka marka)
        {
            TransportMarka dbmarka = await _markaService.TGetByIdAsync(id);
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
