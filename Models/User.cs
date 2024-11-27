namespace TOR.API.Models;

public class User
{
    public int Id { get; set; }
    public string Firstname { get; set; } = string.Empty;
    public string Middlename { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Suffix { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string AccountType { get; set; } = "User";
    public string Status { get; set; } = "Active";
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public Municipality? Municipality { get; set; }
    public Establishment? Establishment { get; set; }
}