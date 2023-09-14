using Zadanie_4.Models;
using Microsoft.EntityFrameworkCore;

namespace Zadanie_4.Data
{
    public class KomDbContext: DbContext
    {
        public KomDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Komunikat> messages { get; set; }
    }
}
