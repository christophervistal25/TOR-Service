using Microsoft.EntityFrameworkCore;
using TOR.API.Data;
using TOR.API.Interfaces;
using TOR.API.Models;

namespace TOR.API.Repositories;

public class EstablishmentRepository : IEstablishmentRepository
{
    private readonly ApplicationDBContext _context;

    public EstablishmentRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    
    public async Task<(List<Establishment>, int)> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm)
    {
        var query = _context.Establishments.Include(e => e.Municipality).AsQueryable();

        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(m => m.Name.Contains(searchTerm) || m.Municipality.Name.Contains(searchTerm));
        }
        
        var totalCount = await query.CountAsync();
        var establishments = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (establishments, totalCount);
    }
    
    public async Task<List<Establishment>> GetAllAsync()
    {
        return await _context.Establishments.Include(e => e.Municipality).ToListAsync();
    }

    public async Task<Establishment> GetByIdAsync(int id)
    {
        return await _context.Establishments.Include(e => e.Municipality).FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<Establishment> AddAsync(Establishment establishment)
    {
        var municipality = await _context.Municipalities.FindAsync(establishment.Municipality.Id);
        Console.Write(establishment.Municipality.Id);
        if (municipality != null)
        {
            establishment.Municipality = municipality;
        }
        else
        {
            // Handle the case where the municipality is not found
            throw new Exception("Municipality not found");
        }

        _context.Establishments.Add(establishment);
        await _context.SaveChangesAsync();
        return establishment;
    }

    public async Task<Establishment> UpdateAsync(int id, Establishment establishment)
    {
        var existingEstablishment = await _context.Establishments.FindAsync(id);
        if (existingEstablishment == null) return null;

        var municipality = await _context.Municipalities.FindAsync(establishment.Municipality.Id);
        if (municipality != null)
        {
            existingEstablishment.Municipality = municipality;
        }
        else
        {
            // Handle the case where the municipality is not found
            throw new Exception("Municipality not found");
        }

        existingEstablishment.Name = establishment.Name;
        existingEstablishment.Address = establishment.Address;
        existingEstablishment.Contact = establishment.Contact;
        existingEstablishment.Email = establishment.Email;
        existingEstablishment.Category = establishment.Category;
        existingEstablishment.Status = establishment.Status;
        existingEstablishment.DateCreated = establishment.DateCreated;

        await _context.SaveChangesAsync();
        return existingEstablishment;
    }
    public async Task<Establishment> DeleteAsync(int id)
    {
        var establishment = await _context.Establishments.FindAsync(id);
        if (establishment == null) return null;

        _context.Establishments.Remove(establishment);
        await _context.SaveChangesAsync();
        return establishment;
    }
}