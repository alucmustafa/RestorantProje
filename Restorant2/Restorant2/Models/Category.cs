using System.ComponentModel.DataAnnotations;

namespace Restorant2.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
