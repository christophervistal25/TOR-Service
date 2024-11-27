using Microsoft.EntityFrameworkCore;
using TOR.API.Data;
using TOR.API.DTOs;
using TOR.API.Interfaces;
using TOR.API.Models;

namespace TOR.API.Repositories;

public class MunicipalityRepository:IMunicipalityRepository
{
    private readonly ApplicationDBContext _context;
    public MunicipalityRepository(ApplicationDBContext context)
    {
        _context = context;
    }
    
    
    public async Task<(List<Municipality>, int)> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm)
    {
        var query = _context.Municipalities.AsQueryable();

        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(m => m.Name.Contains(searchTerm) || m.Province.Contains(searchTerm));
        }

        var totalCount = await query.CountAsync();
        var municipalities = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (municipalities, totalCount);
    }
    
    public Task<List<Municipality>> GetAllAsync()
    {
        return _context.Municipalities
            .ToListAsync();
    }

    public Task<Municipality> GetByIdAsync(int id)
    {
        return _context.Municipalities
            .FirstOrDefaultAsync(x => x.Id == id)!;
        
    }

    public Task<Municipality> AddAsync(Municipality entity)
    {
        _context.Municipalities.AddAsync(entity);
        _context.SaveChanges();
        return Task.FromResult(entity);
    }

    public Task<Municipality> UpdateAsync(int id, Municipality entity)
    {
        var municipality = _context.Municipalities.FirstOrDefault(x => x.Id == id);
        if (municipality != null)
        {
            municipality.Name = entity.Name;
            municipality.Province = entity.Province;
            municipality.Contact = entity.Contact;
            municipality.Email = entity.Email;
            _context.SaveChanges();
        }
        return Task.FromResult(municipality);
    }
    public Task<Municipality> DeleteAsync(int id)
    {
        var municipality = _context.Municipalities.FirstOrDefault(x => x.Id == id);
        if (municipality != null)
        {
            _context.Municipalities.Remove(municipality);
            _context.SaveChanges();
        }
        return Task.FromResult(municipality);
    }
}