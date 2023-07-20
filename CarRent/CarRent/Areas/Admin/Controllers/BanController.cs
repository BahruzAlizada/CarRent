using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BanController : Controller
    {
        private readonly IBanService _banService;
        public BanController(IBanService banService)
        {
            _banService = banService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<TransportBan> bans = await _banService.TGetListAsync();
            return View(bans);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(TransportBan ban)
        {
            await _banService.TAddAsync(ban);
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int id)
        {
            TransportBan dbban = await _banService.TGetByIdAsync(id);
            if (dbban == null)
                return BadRequest();

            return View(dbban);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int id, TransportBan ban)
        {
            TransportBan dbban = await _banService.TGetByIdAsync(id);
            if (dbban == null)
                return BadRequest();

            dbban.Name = ban.Name;

            await _banService.TUpdateAsync(ban);
            return RedirectToAction("Index");
        }
        #endregion

        #region Activity
        public async Task<IActionResult> Activity(int? id)
        {
            await _banService.TActivity(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
