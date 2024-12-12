namespace TOR.API.DTOs;

public class UserDTO
{
    public string? Id { get; set; }
    public string Firstname { get; set; } = string.Empty;
    public string Middlename { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Suffix { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string AccountType { get; set; } = "User";
    public string Status { get; set; } = "Active";
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public int? MunicipalityId { get; set; }
    public int? EstablishmentId { get; set; }
    
    public MunicipalityDTO? Municipality { get; set; }
    
    public EstablishmentDTO? Establishment { get; set; }
    
    public string Password { get; set; } = string.Empty;
}