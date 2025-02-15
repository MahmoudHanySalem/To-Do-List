using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class ToDoDBContext : DbContext
    {
        public ToDoDBContext(DbContextOptions<ToDoDBContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }  // Ensure this matches your entity

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=todo.db"); // Change this for SQL Server if needed
            }
        }
    }
}
