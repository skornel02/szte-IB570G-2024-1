using hazi3.Entities;
using Microsoft.EntityFrameworkCore;

namespace hazi3.Persistance;

public class ApplicationDbContext : DbContext
{
    public DbSet<PetEntity> Pets { get; set; }

    public DbSet<CategoryEntity> Categories { get; set; }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PetEntity>()
            .Property(_ => _.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<PetEntity>()
            .HasOne(_ => _.Category)
            .WithMany(_ => _.Pets)
            .HasForeignKey(_ => _.CategoryId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<CategoryEntity>()
            .Property(_ => _.Id)
            .ValueGeneratedOnAdd();

    }
}
