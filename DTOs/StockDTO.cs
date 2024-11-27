using TOR.API.Models;

namespace TOR.API.DTOs;

public class StockDTO
{
    public int Id { get; set; }

    public string Symbol { get; set; } = String.Empty;

    public string CompanyName { get; set; } = String.Empty;
    
    public decimal Purchase { get; set; } = decimal.Zero;

    public decimal LastDiv { get; set; }

    public string Industry { get; set; } = String.Empty;
    
    public long MarketCap { get; set; }
    
}