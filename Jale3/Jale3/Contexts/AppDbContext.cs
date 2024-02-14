using Microsoft.EntityFrameworkCore;

namespace Jale3.Contexts
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {
            
        }
    }
}
