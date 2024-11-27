namespace TOR.API.Models;

public class Municipality
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Province { get; set; } = "Surigao del Sur";
    public string Contact { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}