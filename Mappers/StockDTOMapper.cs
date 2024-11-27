using TOR.API.DTOs;
using TOR.API.Models;

namespace TOR.API.Mappers;

public static class StockDTOMapper
{
    public static StockDTO StockToDTO(this Stock? stock)
    {
        return new StockDTO()
        {
            Id = stock.Id,
            Symbol = stock.Symbol,
            CompanyName = stock.CompanyName,
            Purchase = stock.Purchase,
            LastDiv = stock.LastDiv,
            Industry = stock.Industry,
            MarketCap = stock.MarketCap,
        };
    }

    
    public static StockDTO StockToDTOWithoutComment(this Stock? stock)
    {
        return new StockDTO()
        {
            Id = stock.Id,
            Symbol = stock.Symbol,
            CompanyName = stock.CompanyName,
            Purchase = stock.Purchase,
            LastDiv = stock.LastDiv,
            Industry = stock.Industry,
            MarketCap = stock.MarketCap,
        };
    }


    public static Stock? StockFromUpdateDTO(this UpdateStockDTO stockDTO)
    {
        return new Stock()
        {
            Symbol = stockDTO.Symbol,
            CompanyName = stockDTO.CompanyName,
            Purchase = stockDTO.Purchase,
            LastDiv = stockDTO.LastDiv,
            Industry = stockDTO.Industry,
            MarketCap = stockDTO.MarketCap,
        };
    }
}