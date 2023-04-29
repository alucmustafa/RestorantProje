using System.ComponentModel.DataAnnotations;

namespace Restorant2.Models
{
	public class Hakkımızda
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }

	}
}
