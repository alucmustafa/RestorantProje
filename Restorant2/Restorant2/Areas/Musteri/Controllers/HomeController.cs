using AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NToastNotify;
using Restorant2.Data;
using Restorant2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Restorant2.Areas.Musteri.Controllers
{

	[Area("Musteri")]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _db;
		private readonly IToastNotification _toast;
        private readonly IWebHostEnvironment _whe;

        public HomeController(ILogger<HomeController> logger , ApplicationDbContext db ,IToastNotification toast,IWebHostEnvironment whe)
		{
			_logger = logger;
			_db=db;
			_toast = toast;
			_whe = whe; 
		}

		public IActionResult Index()
		{
			var menu = _db.Menuler.Where(i => i.OzelMenu).ToList();
			return View(menu);
		}
		public IActionResult Menu()
		{

			var menu = _db.Menuler.ToList();
			return View(menu);
		}
        // GET: Yonetici/Rezervasyon/Create
        public IActionResult Rezervasyon()
        {
            return View();
        }

        // POST: Yonetici/Rezervasyon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Rezervasyon([Bind("Id,Name,Email,TelefonNo,Sayi,Saat,Tarih")] Rezervasyon rezervasyon)
        {
            if (ModelState.IsValid)
            {
                _db.Add(rezervasyon);
				await _db.SaveChangesAsync();
				//hata mesajını _toast ile tanımladık...
				_toast.AddSuccessToastMessage("Rezervasyon işleminiz başarıyla gerçekleştirilmiştir.İYİ GÜNLER.");
                return RedirectToAction(nameof(Index));
            }

			
            return View(rezervasyon);
        }


        public IActionResult Galeri()
		{

			var galeri = _db.Galeriler.ToList();
			return View(galeri);
		}
		public IActionResult About()
		{

            var hakkimizda = _db.hakkımızdas.ToList();
            return View(hakkimizda);
            
		}
		public IActionResult Blog()
		{
			return View();
		}
        // POST: Yonetici/Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Blog(Blog blog)
        {
            if (ModelState.IsValid)
            {
                blog.Tarih = DateTime.Now;
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
                    if (blog.Image != null)
                    {
                        var ImagePath = Path.Combine(_whe.WebRootPath, blog.Image.TrimStart('\\'));

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
                    blog.Image = @"\WebSite\menu\" + fileName + extn;

                }



                _db.Add(blog);
                await _db.SaveChangesAsync();           
                _toast.AddSuccessToastMessage("Yorumunuz iletildi.Onaylandığında size bildirim gelecektir.");
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }
		public IActionResult Contact()
		{
			return View();
		}
	
		public IActionResult Iletisim()
		{
			return View();
		}
		// POST: Yonetici/Iletisim/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Iletisim(Iletisim iletisim)
		{
			if (ModelState.IsValid)
			{ iletisim.Tarih=DateTime.Now;
				_db.Add(iletisim);
				await _db.SaveChangesAsync();
				_toast.AddSuccessToastMessage("Mesajınız iletildi.");
				return RedirectToAction(nameof(Index));
			}
			return View(iletisim);
		}
		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult CateygoryDetails(int? id) {

			var menu = _db.Menuler.Where(i => i.CategoryId == id).ToList();
			ViewBag.KetegoriId = id;

			return View(menu);
		
		
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
