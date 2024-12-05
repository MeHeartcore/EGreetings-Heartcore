using Microsoft.EntityFrameworkCore;
using EGreetingsAdmin.Models;

namespace EGreetingsAdmin.Data
{

    public partial class EGreetingsDbContext : DbContext
    {
        public EGreetingsDbContext()
        {
        }

        public EGreetingsDbContext(DbContextOptions<EGreetingsDbContext> options) : base(options) {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}

