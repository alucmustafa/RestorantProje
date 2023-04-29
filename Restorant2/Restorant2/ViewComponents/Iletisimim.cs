using Microsoft.AspNetCore.Mvc;
using Restorant2.Data;
using System.Linq;

namespace Restorant2.ViewComponents
{
    public class Iletisimim:ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public Iletisimim(ApplicationDbContext db)
        {
            _db = db;
        }


        public IViewComponentResult Invoke()
        {

            //Invoke bir IVeiwComponetResult döndüren uyumlu yöntem
            //Invoke: Çağırmak
            var iletisimim = _db.Iletisimims.ToList();
            return View(iletisimim);
        }
    }
}
