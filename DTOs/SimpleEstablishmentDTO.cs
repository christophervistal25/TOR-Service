namespace TOR.API.DTOs;

public class SimpleEstablishmentDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Status { get; set; } = "Active";
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    
    public AccomodationClassificationDTO AccomodationClassification { get; set; }
    
}