namespace TOR.API.Models;

public class DAE2
{
    public int Id { get; set; }
    public int RoomsOccupied { get; set; }
    public int RoomsAvailableForTheMonth { get; set; }
    public int TotalGuestNights { get; set; }

    public decimal AverageMonthlyOccupancyRate { get; set; } = 0.000m;
    public decimal AverageLengthOfStayNights { get; set; } = 0.000m;

    public int DAE1BId { get; set; }
    public DAE1B DAE1B { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}