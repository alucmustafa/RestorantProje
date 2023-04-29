using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restorant2.Data;
using Restorant2.Models;

namespace Restorant2.Areas.Yonetici.Controllers
{
    [Area("Yonetici")]
    [Authorize]
    public class HakkımızdaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HakkımızdaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Yonetici/Hakkımızda
        public async Task<IActionResult> Index()
        {
            return View(await _context.hakkımızdas.ToListAsync());
        }

        // GET: Yonetici/Hakkımızda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hakkımızda = await _context.hakkımızdas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hakkımızda == null)
            {
                return NotFound();
            }

            return View(hakkımızda);
        }

        // GET: Yonetici/Hakkımızda/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Yonetici/Hakkımızda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] Hakkımızda hakkımızda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hakkımızda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hakkımızda);
        }

        // GET: Yonetici/Hakkımızda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hakkımızda = await _context.hakkımızdas.FindAsync(id);
            if (hakkımızda == null)
            {
                return NotFound();
            }
            return View(hakkımızda);
        }

        // POST: Yonetici/Hakkımızda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] Hakkımızda hakkımızda)
        {
            if (id != hakkımızda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hakkımızda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HakkımızdaExists(hakkımızda.Id))
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
            return View(hakkımızda);
        }

        // GET: Yonetici/Hakkımızda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hakkımızda = await _context.hakkımızdas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hakkımızda == null)
            {
                return NotFound();
            }

            return View(hakkımızda);
        }

        // POST: Yonetici/Hakkımızda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hakkımızda = await _context.hakkımızdas.FindAsync(id);
            _context.hakkımızdas.Remove(hakkımızda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HakkımızdaExists(int id)
        {
            return _context.hakkımızdas.Any(e => e.Id == id);
        }
    }
}
