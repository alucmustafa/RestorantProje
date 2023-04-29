using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restorant2.Data;
using Restorant2.Models;

namespace Restorant2.Areas.Yonetici.Controllers
{
    [Area("Yonetici")]
    //[Authorize]
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _whe;
        public MenuController(ApplicationDbContext context, IWebHostEnvironment whe)
        {
            _context = context;
            _whe = whe;
        }

        // GET: Yonetici/Menu
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Menuler.Include(m => m.Categories);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Yonetici/Menu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menuler
                .Include(m => m.Categories)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }

        // GET: Yonetici/Menu/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: Yonetici/Menu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Menu menu)
        {
            if (ModelState.IsValid)
            {
                //Dosyaları yüklemek için istek yaptık....
                var files = HttpContext.Request.Form.Files;

                //seçilen dosya olup olamdığına baktık...
                if (files.Count > 0)
                {
                    //Dosya ismini adresinden aldık
                    var fileName = Guid.NewGuid().ToString();
                    //Adres ile dosya yolunu bağladık
                    var uploads = Path.Combine(_whe.WebRootPath, @"WebSite\menu");
                 
                    //Birden fazla seçilen dosya olmaması için ilk seçileni  tanımladık..
                   var extn = Path.GetExtension(files[0].FileName);
                    if (menu.Image != null)
                    {
                        var ImagePath = Path.Combine(_whe.WebRootPath, menu.Image.TrimStart('\\'));
                      
                        //Ürün için başka bir fotoğraf Yüklü ise onu silecek
                        if (System.IO.File.Exists(ImagePath))
                        {
                            System.IO.File.Delete(ImagePath);
                        }

                    
                    }
                    using (var fileStremas = new FileStream(Path.Combine(uploads, fileName + extn), FileMode.Create))
                    {
                        files[0].CopyTo(fileStremas);
                    }
                    menu.Image = @"\WebSite\menu\" + fileName + extn;

                }


                _context.Add(menu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
       
            return View(menu);
        }

        // GET: Yonetici/Menu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menuler.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", menu.CategoryId);
            return View(menu);
        }

        // POST: Yonetici/Menu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(  Menu menu)
        {
          

            if (ModelState.IsValid)
            {
                //Dosyaları yüklemek için istek yaptık....
                var files = HttpContext.Request.Form.Files;

                //seçilen dosya olup olamdığına baktık...
                if (files.Count > 0)
                {
                    //Dosya ismini adresinden aldık
                    var fileName = Guid.NewGuid().ToString();
                    //Adres ile dosya yolunu bağladık
                    var uploads = Path.Combine(_whe.WebRootPath, @"WebSite\menu");

                    //Birden fazla seçilen dosya olmaması için ilk seçileni  tanımladık..
                    var extn = Path.GetExtension(files[0].FileName);
                    if (menu.Image != null)
                    {
                        var ImagePath = Path.Combine(_whe.WebRootPath, menu.Image.TrimStart('\\'));

                        //Ürün için başka bir fotoğraf Yüklü ise onu silecek
                        if (System.IO.File.Exists(ImagePath))
                        {
                            System.IO.File.Delete(ImagePath);
                        }


                    }
                    using (var fileStremas = new FileStream(Path.Combine(uploads, fileName + extn), FileMode.Create))
                    {
                        files[0].CopyTo(fileStremas);
                    }
                    menu.Image = @"\WebSite\menu\" + fileName + extn;

                }

                _context.Update(menu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(menu);
        }

        // GET: Yonetici/Menu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menuler
                .Include(m => m.Categories)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }

        // POST: Yonetici/Menu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menu = await _context.Menuler.FindAsync(id);

			if (menu.Image != null)
			{
				var ImagePath = Path.Combine(_whe.WebRootPath, menu.Image.TrimStart('\\'));

				//Ürün için başka bir fotoğraf Yüklü ise onu silecek
				if (System.IO.File.Exists(ImagePath))
				{
					System.IO.File.Delete(ImagePath);
				}


			}


			_context.Menuler.Remove(menu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuExists(int id)
        {
            return _context.Menuler.Any(e => e.Id == id);
        }
    }
}
