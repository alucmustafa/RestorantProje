using Microsoft.AspNetCore.Mvc;
using Restorant2.Data;
using System.Linq;

namespace Restorant2.ViewComponents
{
	public class CategoryList : ViewComponent
	{
		private readonly ApplicationDbContext _db;
        public CategoryList(ApplicationDbContext db)
        {
            _db = db;
        }


        public IViewComponentResult Invoke()
        {

            //Invoke bir IVeiwComponetResult döndüren uyumlu yöntem
            //Invoke: Çağırmak
            var category=_db.Categories.ToList();
            return View(category);
        }


    }
}
