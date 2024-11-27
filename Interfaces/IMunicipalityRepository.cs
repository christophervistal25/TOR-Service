using TOR.API.Models;
using TOR.API.Repositories;

namespace TOR.API.Interfaces;

public interface IMunicipalityRepository:IBaseRepository<Municipality>
{ 
    Task<(List<Municipality>, int)> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm);
}

