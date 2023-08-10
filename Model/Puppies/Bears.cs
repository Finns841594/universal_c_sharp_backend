using System.ComponentModel.DataAnnotations.Schema;

namespace puppiesApi;

public class Bear
{
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    
    public string? Name { get; set; }
    [Column("breed")]

    public string? Breed { get; set; }
    [Column("created_at")]

    public DateTime CreatedAt { get; set; }
}