using System.ComponentModel.DataAnnotations;

namespace Tirlea_Mihai_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Display(Name = "Nume editura")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
