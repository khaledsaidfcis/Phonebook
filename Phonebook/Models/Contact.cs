using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Phonebook.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9§®™©ʬ@]*$", ErrorMessage = "Only special characters  (§,®,™,©,ʬ,@) are allowed")]
        public string Name { get; set; }
        [Required]
        public int MaxNumbers { get; set; }

        public virtual List<ContactNumber>? ContactNumbers { get; set; }

    }
}
