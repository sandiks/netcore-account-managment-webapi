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
    }
}