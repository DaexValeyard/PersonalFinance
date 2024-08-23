using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Infrastructure.Persistence;

internal class PersonalFinanceDbContext(DbContextOptions<PersonalFinanceDbContext> options)
    : IdentityDbContext<User>(options)
{
    internal DbSet<Statement> Statements { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Statements)
            .WithOne(s => s.Owner)
            .HasForeignKey(s => s.OwnerId);
    }
}
