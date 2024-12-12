namespace TOR.API.Models;

public class DAE1BDetail
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public int DAE1BId { get; set; }
    public DAE1B DAE1B { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}