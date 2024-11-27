using TOR.API.DTOs;
using TOR.API.Models;

namespace TOR.API.Mappers;

public static class MunicipalityDTOMapper
{
    public static MunicipalityDTO MunicipalityToDTO(this Municipality? municipality)
    {
        return new MunicipalityDTO()
        {
            Id = municipality.Id,
            Name = municipality.Name,
            Province = municipality.Province,
            Contact = municipality.Contact,
            Email = municipality.Email,
        };
    }
    
    public static Municipality MunicipalityDTOtoMunicipality(this MunicipalityDTO? municipalityDTO)
    {
        return new Municipality()
        {
            Name = municipalityDTO.Name,
            Province = municipalityDTO.Province,
            Contact = municipalityDTO.Contact,
            Email = municipalityDTO.Email,
        };
    }
    
    
    
    

}