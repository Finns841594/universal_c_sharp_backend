using Microsoft.EntityFrameworkCore;
using puppiesApi;

public class MvcDataContext : DbContext
{
  public MvcDataContext (DbContextOptions<MvcDataContext> options) : base (options)
  {}

  public DbSet<Puppy>? Puppies { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseNpgsql("User Id=postgres;Password=postgres;Server=127.0.0.1;Port=5432;Database=puppies");
  }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Puppy>().HasData(
    new { name = "Rex", breed = "German Shepherd" },
    new { name = "Buddy", breed = "Golden Retriever" },
    new { name = "Max", breed = "Bulldog" },
    new { name = "Bella", breed = "Labrador Retriever" },
    new { name = "Milo", breed = "Poodle" },
    new { name = "Daisy", breed = "Rottweiler" },
    new { name = "Luna", breed = "Yorkshire Terrier" });
  }

}