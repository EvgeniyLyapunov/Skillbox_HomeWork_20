using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skillbox_HomeWork_20.Models
{
    public class PhoneBook: DbContext
    {
        public DbSet<Person> People { get; set; }

        public PhoneBook(DbContextOptions<PhoneBook> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
