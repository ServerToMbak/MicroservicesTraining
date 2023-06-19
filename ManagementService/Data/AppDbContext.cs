using ManagementService.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementService.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) :base(opt)
        {
            
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Instructor> Instructors {get; set;}
    }
}