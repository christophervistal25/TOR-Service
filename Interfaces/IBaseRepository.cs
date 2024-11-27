namespace TOR.API.Repositories;

public interface IBaseRepository<T>
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T>  AddAsync(T entity);
    Task<T> UpdateAsync(int id, T entity);
    Task<T> DeleteAsync(int id);
}