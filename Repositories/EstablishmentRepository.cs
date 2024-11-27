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
        if (municipality != null)
        {
            establishment.Municipality = municipality;
        }

        _context.Establishments.Add(establishment);
        await _context.SaveChangesAsync();
        return establishment;
    }

    public async Task<Establishment> UpdateAsync(int id, Establishment establishment)
    {
        var existingEstablishment = await _context.Establishments.FindAsync(id);
        if (existingEstablishment == null) return null;

        existingEstablishment.Name = establishment.Name;
        existingEstablishment.Address = establishment.Address;
        existingEstablishment.Contact = establishment.Contact;
        existingEstablishment.Email = establishment.Email;
        existingEstablishment.Municipality = establishment.Municipality;
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