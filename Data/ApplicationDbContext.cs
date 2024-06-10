// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using PersonalTaskManager.Models;

namespace PersonalTaskManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
