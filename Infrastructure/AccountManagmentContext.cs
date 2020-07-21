using AccountManagmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountManagmentSystem.Infrastructure
{
    public class AccountManagmentContext : DbContext
    {
        public AccountManagmentContext(DbContextOptions<AccountManagmentContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}