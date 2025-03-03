using ISqlRepositoryWithValidation.Models;
using Microsoft.EntityFrameworkCore;

namespace ISqlRepositoryWithValidation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<AppUser> AppUser { get; set; }
    }
}
