using KonsultBonus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonsultBonus.Controllers
{
    public class KonsulterController : Controller
    {
        private readonly Context _context;

        public KonsulterController(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.konsulter.ToListAsync());
        }

        [HttpGet]
        public IActionResult AddKonsult()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddKonsult(Konsulter konsult)
        {
            await _context.konsulter.AddAsync(konsult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateKonsult(int id)
        {
            Konsulter konsult = await _context.konsulter.FindAsync(id);
            return View(konsult);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateKonsult(Konsulter konsult)
        {
            _context.konsulter.Update(konsult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteKonsult(int id)
        {
            Konsulter konsult = await _context.konsulter.FindAsync(id);
            _context.konsulter.Remove(konsult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
