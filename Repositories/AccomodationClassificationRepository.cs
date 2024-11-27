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
        var classification = await _context.AccomodationClassifications.FindAsync(id);
        if (classification == null) return null;

        _context.AccomodationClassifications.Remove(classification);
        await _context.SaveChangesAsync();
        return classification;
    }
}