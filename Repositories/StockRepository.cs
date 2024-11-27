using Microsoft.EntityFrameworkCore;
using TOR.API.Data;
using TOR.API.DTOs;
using TOR.API.Interfaces;
using TOR.API.Models;

namespace TOR.API.Repositories;

public class StockRepository:IStockRepository
{
    private readonly ApplicationDBContext _context;
    public StockRepository(ApplicationDBContext context)
    {
        _context = context;
    }
    
    public Task<List<Stock>> GetAllAsync()
    {
        return _context.Stocks
                .Include(o => o.Comments)
                .ToListAsync();
    }

    public Task<Stock> GetByIdAsync(int id)
    {
        Task<Stock> stock =  _context.Stocks.FirstOrDefaultAsync(s => s.Id == id);
        return stock;
    }

    public async Task<Stock> AddAsync(Stock stock)
    {
        await _context.Stocks.AddAsync(stock);
        await _context.SaveChangesAsync();
        return stock;
    }

    public async Task<Stock> UpdateAsync(int id, Stock s)
    {
        var stock = await _context.Stocks.FindAsync(id);
        

        if (stock != null)
        {
            stock.Symbol = s.Symbol;
            stock.CompanyName = s.CompanyName;
            stock.Purchase = s.Purchase;
            stock.LastDiv = s.LastDiv;
            stock.Industry = s.Industry;
            stock.MarketCap = s.MarketCap;
             _context.Update(stock);
            await _context.SaveChangesAsync();
        }


        return stock;
    }

    public async Task<Stock> DeleteAsync(int id)
    {     
        var stock = await _context.Stocks.FirstOrDefaultAsync(s => s.Id == id);
        if (stock != null)
        {
            _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();
        }
        return stock;
    }
}