using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeThiMaiAnh076;
using LeThiMaiAnh076.Data;

namespace LeThiMaiAnh076.Controllers
{
    public class LeThiMaiAnhController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeThiMaiAnhController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LeThiMaiAnh
        public async Task<IActionResult> Index()
        {
            return View(await _context.LeThiMaiAnh.ToListAsync());
        }

        // GET: LeThiMaiAnh/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leThiMaiAnh = await _context.LeThiMaiAnh
                .FirstOrDefaultAsync(m => m.HoTen == id);
            if (leThiMaiAnh == null)
            {
                return NotFound();
            }

            return View(leThiMaiAnh);
        }

        // GET: LeThiMaiAnh/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeThiMaiAnh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HoTen,MaSV,Diem")] LeThiMaiAnh leThiMaiAnh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leThiMaiAnh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leThiMaiAnh);
        }

        // GET: LeThiMaiAnh/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leThiMaiAnh = await _context.LeThiMaiAnh.FindAsync(id);
            if (leThiMaiAnh == null)
            {
                return NotFound();
            }
            return View(leThiMaiAnh);
        }

        // POST: LeThiMaiAnh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HoTen,MaSV,Diem")] LeThiMaiAnh leThiMaiAnh)
        {
            if (id != leThiMaiAnh.HoTen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leThiMaiAnh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeThiMaiAnhExists(leThiMaiAnh.HoTen))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leThiMaiAnh);
        }

        // GET: LeThiMaiAnh/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leThiMaiAnh = await _context.LeThiMaiAnh
                .FirstOrDefaultAsync(m => m.HoTen == id);
            if (leThiMaiAnh == null)
            {
                return NotFound();
            }

            return View(leThiMaiAnh);
        }

        // POST: LeThiMaiAnh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var leThiMaiAnh = await _context.LeThiMaiAnh.FindAsync(id);
            if (leThiMaiAnh != null)
            {
                _context.LeThiMaiAnh.Remove(leThiMaiAnh);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeThiMaiAnhExists(string id)
        {
            return _context.LeThiMaiAnh.Any(e => e.HoTen == id);
        }
    }
}
