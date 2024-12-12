namespace TOR.API.DTOs;

public class EstablishmentDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int MunicipalityId { get; set; }
    public MunicipalityDTO? Municipality { get; set; }
    
    public int AccomodationClassificationId { get; set; }
    public AccomodationClassificationDTO AccomodationClassification { get; set; }
    public string Category { get; set; } = "HTL";
    public string Status { get; set; } = "Active";
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
}