using Microsoft.AspNetCore.Identity;
using TOR.API.Models;

public class User:IdentityUser
{
    public int Id { get; set; }
    public string Firstname { get; set; } = string.Empty;
    public string Middlename { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Suffix { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string AccountType { get; set; } = "User";
    public string Status { get; set; } = "Active";
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public int? MunicipalityId { get; set; }
    public Municipality? Municipality { get; set; }
    public int? EstablishmentId { get; set; }
    public Establishment? Establishment { get; set; }
}