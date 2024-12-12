using Microsoft.EntityFrameworkCore;
using TOR.API.Data;
using TOR.API.Interfaces;
using TOR.API.Models;

namespace TOR.API.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDBContext _context;

    public UserRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public Task<(List<User>, int)> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm)
    {
        var users = _context.Users.Include(u => u.Municipality).Include(u => u.Establishment).AsQueryable();
        if (!string.IsNullOrEmpty(searchTerm))
        {
            users = users.Where(u => u.Firstname.Contains(searchTerm) || u.Middlename.Contains(searchTerm) ||
                                     u.Lastname.Contains(searchTerm) || u.Suffix.Contains(searchTerm) ||
                                         u.Email.Contains(searchTerm) ||
                                     u.Contact.Contains(searchTerm) || u.AccountType.Contains(searchTerm) ||
                                     u.Status.Contains(searchTerm));
        }

        var count = users.Count();
        var items = users.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        return Task.FromResult((items, count));
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _context.Users.Include(u => u.Municipality).Include(u => u.Establishment).ToListAsync();
    }


    public async Task<User?> GetByIdAsync(string id)
    {
        return await _context.Users.Include(u => u.Municipality).Include(u => u.Establishment)
            .FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User?> AddAsync(User? user)
    {
        if (user.MunicipalityId.HasValue)
        {
            var municipality = await _context.Municipalities.FindAsync(user.MunicipalityId.Value);
            if (municipality == null)
            {
                throw new Exception("Municipality not found");
            }
        }
        
        user.Id = Guid.NewGuid().ToString();
        
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User> UpdateAsync(string id, User user)
    {
        var existingUser = await _context.Users.Include(u => u.Municipality).Include(u => u.Establishment)
            .FirstOrDefaultAsync(u => u.Id == id);
        if (existingUser == null) return null;

        if (user.MunicipalityId != null)
        {
            var municipality = await _context.Municipalities.FindAsync(user.MunicipalityId);
            if (municipality != null)
            {
                existingUser.Municipality = municipality;
            }
            else
            {
                throw new Exception("Municipality not found");
            }
        }

        if (user.EstablishmentId != null)
        {
            var establishment = await _context.Establishments.IgnoreAutoIncludes().FirstOrDefaultAsync(e => e.Id == user.EstablishmentId);
            if (establishment != null)
            {
                existingUser.Establishment = establishment;
            }
            else
            {
                throw new Exception("Establishment not found");
            }
        }

        existingUser.Firstname = user.Firstname;
        existingUser.Middlename = user.Middlename;
        existingUser.Lastname = user.Lastname;
        existingUser.Suffix = user.Suffix;
        existingUser.Email = user.Email;
        existingUser.Contact = user.Contact;
        existingUser.AccountType = user.AccountType;
        existingUser.Status = user.Status;
        existingUser.DateCreated = user.DateCreated;

        await _context.SaveChangesAsync();
        return existingUser;
    }

    public async Task<User> DeleteAsync(string id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return null;

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public Task<User> GetByEmailAsync(string email)
    {
        return _context.Users.Include(u => u.Municipality).Include(u => u.Establishment)
            .FirstOrDefaultAsync(u => u.Email == email);
    }
}