using BookMovie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly EFDdataContext _context;
        public HomeController(EFDdataContext context)
        {
            _context = context;
        }
        

        public async Task<IActionResult> Index()
        {
            var DbContext = _context.LichChieus;
            return View(await DbContext.ToListAsync());
        }

        public async Task<IActionResult> Booked()
        {
            var DbContext = _context.DatVes;
            return View(await DbContext.ToListAsync());
        }
        public IActionResult Book()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Book([Bind("sdt,tenrap,sove")] DatVe datVe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datVe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Booked));
            }
            
            return View(datVe);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
