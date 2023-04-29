using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Restorant2.Models
{
	public class Galeri
	{
		[Key]
		public int Id { get; set; }

        public string Image { get; set; }

    }
}
