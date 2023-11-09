using ATMBank_.Models;
using Microsoft.EntityFrameworkCore;

namespace ATMBank_.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            :base(options)
        {
            
        }

        public DbSet<Casette> Casettes { get; set; }
        public DbSet<Nasabah> Nasabahs { get; set; }
        public DbSet<ATM> ATMs { get; set; }
    }
}
