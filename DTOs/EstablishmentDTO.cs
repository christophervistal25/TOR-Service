using TOR.API.DTOs;

public class EstablishmentDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Contact { get; set; }
    public string Email { get; set; }
    public int MunicipalityId { get; set; }
    public MunicipalityDTO Municipality { get; set; } // Add this line
    public string Category { get; set; }
    public string Status { get; set; }
    public DateTime DateCreated { get; set; }
}