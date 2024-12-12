using System.ComponentModel.DataAnnotations;

namespace TOR.API.Models;

public class DAE1ADetail
{
    public int ID { get; set; }

    [Range(1, 31)] public int Day { get; set; }

    public int RoomNumber { get; set; }
    public int GuestCheckedIn { get; set; }
    public int GuestNight { get; set; }
    public int RoomsOccupiedByGuest { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public int DAE1AId { get; set; }
    public DAE1A DAE1A { get; set; }
}