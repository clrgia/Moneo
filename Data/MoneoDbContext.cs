using Microsoft.EntityFrameworkCore;
using Moneo.Api.Models;

namespace Moneo.Api.Data;

    public class MoneoDbContext : DbContext
    {
        public MoneoDbContext(DbContextOptions<MoneoDbContext> options) : base(options){}

        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Operation> Operations { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        modelBuilder.Entity<Account>()
            .Property(a => a.Name)
            .HasMaxLength(100);

        modelBuilder.Entity<Account>()
            .Property(a => a.Type)
            .HasMaxLength(50);

        modelBuilder.Entity<Account>()
            .Property(a => a.InitialBalance)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Category>()
            .Property(c => c.Label)
            .HasMaxLength(100);

        modelBuilder.Entity<Operation>()
            .Property(o => o.Label)
            .HasMaxLength(255);

        modelBuilder.Entity<Operation>()
            .Property(o => o.Amount)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Account>()
            .HasMany(a => a.Operations)
            .WithOne(o => o.Account)
            .HasForeignKey(o => o.AccountId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Category>()
            .HasMany(c => c.Operations)
            .WithOne(o => o.Category)
            .HasForeignKey(o => o.CategoryId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}

