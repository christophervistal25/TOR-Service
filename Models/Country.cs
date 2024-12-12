namespace TOR.API.Models;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public string Continent { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}