using TOR.API.Models;
using TOR.API.Repositories;

namespace TOR.API.Interfaces;

public interface IEstablishmentRepository:IBaseRepository<Establishment>
{
 Task<List<Establishment>> GetEstablishmentByMunicipality(int municipalityId);
}