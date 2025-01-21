using ActionResultts.Entities;
using Microsoft.EntityFrameworkCore;

namespace ActionResultts.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }


        public DbSet<Student> Students { get; set; }

        
    }
}
