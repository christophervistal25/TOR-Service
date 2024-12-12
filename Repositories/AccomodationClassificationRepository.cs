using Microsoft.EntityFrameworkCore;
using TOR.API.Data;
using TOR.API.Interfaces;
using TOR.API.Models;

namespace TOR.API.Repositories;

public class AccomodationClassificationRepository : IAccomodationClassificationRepository
{
    private readonly ApplicationDBContext _context;

    public AccomodationClassificationRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<(List<AccomodationClassification>, int)> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm)
    {
        var query = _context.AccomodationClassifications.AsQueryable();

        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(m => m.Name.Contains(searchTerm));
        }

        var totalCount = await query.CountAsync();
        var accomodationClassifications = await query
            .Where(q => q.Status == "Active")
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (accomodationClassifications, totalCount);
    }

    public async Task<List<AccomodationClassification>> GetAllAsync()
    {
        return await _context.AccomodationClassifications.ToListAsync();
    }

    public async Task<AccomodationClassification> GetByIdAsync(int id)
    {
        return await _context.AccomodationClassifications.FindAsync(id);
    }

    public async Task<AccomodationClassification> AddAsync(AccomodationClassification classification)
    {
        _context.AccomodationClassifications.Add(classification);
        await _context.SaveChangesAsync();
        return classification;
    }

    public async Task<AccomodationClassification> UpdateAsync(int id, AccomodationClassification classification)
    {
        var existingClassification = await _context.AccomodationClassifications.FindAsync(id);
        if (existingClassification == null) return null;

        existingClassification.Name = classification.Name;
        existingClassification.Code = classification.Code;
        existingClassification.Status = classification.Status;
        existingClassification.DateCreated = classification.DateCreated;

        await _context.SaveChangesAsync();
        return existingClassification;
    }

    public async Task<AccomodationClassification> DeleteAsync(int id)
    {
        var classification = await _context.AccomodationClassifications.FirstAsync(classi => classi.Id == id);
        if (classification == null) return null;

        _context.AccomodationClassifications.Remove(classification);
        await _context.SaveChangesAsync();
        return classification;
    }
}