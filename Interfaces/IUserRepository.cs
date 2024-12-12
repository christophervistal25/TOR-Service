using TOR.API.Models;
using TOR.API.Repositories;

namespace TOR.API.Interfaces;

public interface IUserRepository
{
    Task<(List<User>, int)> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm);
    Task<List<User>> GetAllAsync();
    Task<User> GetByIdAsync(string id);
    Task<User>  AddAsync(User entity);
    Task<User> UpdateAsync(string id, User entity);
    Task<User> DeleteAsync(string id);
    
    Task<User> GetByEmailAsync(string email);
}
