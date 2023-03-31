using System.ComponentModel.DataAnnotations;

namespace Phonebook.Models
{
    public class ContactNumber
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public int ContactId { get; set; }

        public virtual Contact? Contact { get; set; }

    }
}
