using System.ComponentModel.DataAnnotations;

namespace Tirlea_Mihai_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "Author")]
        public string FirstName { get; set; }
        [Display(Name = "")]
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
