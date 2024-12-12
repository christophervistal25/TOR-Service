namespace TOR.API.Models;

public class DAE1A
{
    public int Id { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public int? EstablishmentId { get; set; }
    public Establishment? Establishment { get; set; }
    public int UserId { get; set; }
    public User CreatedBy { get; set; }
    public int AvailableRooms { get; set; }
    public decimal AverageGuestNight { get; set; } = 0.000m;
    public decimal AverageRoomOccupancyRate { get; set; } = 0.000m;
    public decimal AverageNumberOfGuestPerRoom { get; set; } = 0.000m;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
} 


