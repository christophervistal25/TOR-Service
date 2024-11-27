namespace TOR.API.DTOs;

public class MunicipalityDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Province { get; set; } = "Surigao del Sur";
    public string Contact { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}