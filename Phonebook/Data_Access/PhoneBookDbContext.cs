using Microsoft.EntityFrameworkCore;
using Phonebook.Models;

namespace Phonebook.Data_Access
{
    public class PhoneBookDbContext: DbContext
    {
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options): base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactNumber> ContactNumber { get; set; }
    }
}
