using Microsoft.AspNetCore.Mvc;
using Restorant2.Data;
using System.Linq;

namespace Restorant2.ViewComponents
{
	public class Comments: ViewComponent
	{
		private readonly ApplicationDbContext _db;
		public Comments(ApplicationDbContext db)
		{
			_db = db;
		}


		public IViewComponentResult Invoke()
		{

			//Invoke bir IVeiwComponetResult döndüren uyumlu yöntem
			//Invoke: Çağırmak
			var comments = _db.Blogs.Where(i => i.Oany).ToList();
			return View(comments);
		}

	}
}
