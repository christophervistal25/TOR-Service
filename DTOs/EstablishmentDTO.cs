using TOR.API.DTOs;

public class EstablishmentDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Contact { get; set; } = String.Empty;
    public string Email { get; set; }
    public int MunicipalityId { get; set; }
    public MunicipalityDTO? Municipality { get; set; }
    public string Category { get; set; } = "HTL";
    public string Status { get; set; } = "Active";
    public DateTime DateCreated { get; set; }
}