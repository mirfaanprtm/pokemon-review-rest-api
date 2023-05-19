namespace WebApplication2.Models;

public class PokemonCategory
{
    public int PokemenId { get; set; }
    public int CategoryId { get; set; }
    public Pokemon Pokemon { get; set; }
    public Category Category { get; set; }
}