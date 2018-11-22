using Microsoft.EntityFrameworkCore;
 
namespace hotchoc.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
