using Microsoft.EntityFrameworkCore;
using puppiesApi;

public class MvcDataContext : DbContext
{
  public MvcDataContext (DbContextOptions<MvcDataContext> options) : base (options)
  {}

  public DbSet<Puppy>? Puppies { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    // Should hide the sql connect string
    optionsBuilder.UseNpgsql("User Id=postgres;Password=postgres;Server=127.0.0.1;Port=5432;Database=puppies");
  }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Puppy>().HasData(
    // Set id to minus numbers to prevent from interfering with real data
    new Puppy { Id = -1, Name = "Rex", Breed = "German Shepherd" },
    new Puppy { Id = -2, Name = "Buddy", Breed = "Golden Retriever" },
    new Puppy { Id = -3, Name = "Max", Breed = "Bulldog" },
    new Puppy { Id = -4, Name = "Bella", Breed = "Labrador Retriever" },
    new Puppy { Id = -5, Name = "Milo", Breed = "Poodle" },
    new Puppy { Id = -6, Name = "Daisy", Breed = "Rottweiler" },
    new Puppy { Id = -7, Name = "Luna", Breed = "Yorkshire Terrier" });
  }

}