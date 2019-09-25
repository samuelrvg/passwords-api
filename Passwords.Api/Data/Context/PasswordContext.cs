using Microsoft.EntityFrameworkCore;
using Passwords.Api.Data.Maps;
using Passwords.Api.Entities;

namespace Passwords.Api.Data.Context
{
    public class PasswordContext : DbContext
    {
        public PasswordContext(DbContextOptions<PasswordContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new AccountMap());
            modelBuilder
                .ApplyConfiguration(new ContentMap());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Content> Content { get; set; }
    }
}
