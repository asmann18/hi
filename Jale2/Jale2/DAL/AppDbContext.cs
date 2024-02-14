using Jale2.Models;
using Microsoft.EntityFrameworkCore;

namespace Jale2.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }


        public DbSet<Jale> Jales{ get; set; }
        public DbSet<Asiman> Asimans{ get; set; }
    }
}
