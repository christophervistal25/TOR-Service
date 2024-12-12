// Establishment.cs

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TOR.API.Models;

public class Establishment
{
    public int Id { get; set; }

    public string? AEIDCode { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Municipality Municipality { get; set; } = new();
    public string Status { get; set; } = "Active";
    
    public int CreatedById { get; set; }
    public User CreatedBy { get; set; }

    public int AccomodationClassificationId { get; set; }
    public AccomodationClassification? AccomodationClassification { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    
}