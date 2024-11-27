namespace TOR.API.Models;

public class Establishment
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Municipality Municipality { get; set; } = new();
    public string Category { get; set; } = string.Empty;
    public string Status { get; set; } = "Active";
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
}