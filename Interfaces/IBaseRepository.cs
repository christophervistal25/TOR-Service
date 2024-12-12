using TOR.API.Models;

namespace TOR.API.Repositories;

public interface IBaseRepository<T>
{
    Task<(List<T>, int)> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm);
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T>  AddAsync(T entity);
    Task<T> UpdateAsync(int id, T entity);
    Task<T> DeleteAsync(int id);
}