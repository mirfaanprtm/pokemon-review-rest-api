using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Pokemon> Pokemon { get; set; }
    public DbSet<PokemonOwner> PokemonOwners { get; set; }
    public DbSet<PokemonCategory> PokemonCategories { get; set; }
    public DbSet<Review> Review { get; set; }
    public DbSet<Reviewer> Reviewer { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PokemonCategory>()
            .HasKey(pc => new { pc.PokemenId, pc.CategoryId });
        modelBuilder.Entity<PokemonCategory>()
            .HasOne(p => p.Pokemon)
            .WithMany(pc => pc.PokemonCategories)
            .HasForeignKey(p => p.PokemenId);
        modelBuilder.Entity<PokemonCategory>()
            .HasOne(p => p.Category)
            .WithMany(pc => pc.PokemonCategories)
            .HasForeignKey(c => c.CategoryId);
        
        modelBuilder.Entity<PokemonOwner>()
            .HasKey(po => new { po.PokemonId, po.OwnerId });
        modelBuilder.Entity<PokemonOwner>()
            .HasOne(p => p.Pokemon)
            .WithMany(po => po.PokemonOwners)
            .HasForeignKey(p => p.PokemonId);
        modelBuilder.Entity<PokemonOwner>()
            .HasOne(p => p.Owner)
            .WithMany(po => po.PokemonOwners)
            .HasForeignKey(o => o.OwnerId);
    }
    
}