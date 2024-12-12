using TOR.API.Enums;

namespace TOR.API.Models;


public class DAE2VolumePerSex
{
    public int Id { get; set; }
    
    public int DAE2Id { get; set; }
    public DAE2 DAE2 { get; set; }
    
    public int PhilippineResidents { get; set; }
    public int NonPhilippineForeignResidents { get; set; }
    public int OverseasFilipinos { get; set; }
    public int OtherUnspecifiedGuest { get; set; }
    
    public decimal Total { get; set; } = 0.000m;
    
    public Gender Gender { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}