using TOR.API.Models;
using TOR.API.DTOs;

namespace TOR.API.Mappers;

public static class EstablishmentMapper
{
    public static EstablishmentDTO EstablishmentToDTO(this Establishment establishment)
    {
        return new EstablishmentDTO
        {
            Id = establishment.Id,
            Name = establishment.Name,
            Address = establishment.Address,
            Contact = establishment.Contact,
            Email = establishment.Email,
            MunicipalityId = establishment.Municipality.Id,
            Municipality = new MunicipalityDTO // Add this block
            {
                Id = establishment.Municipality.Id,
                Name = establishment.Municipality.Name
            },
            Category = establishment.Category,
            Status = establishment.Status,
            DateCreated = establishment.DateCreated
        };
    }

    public static Establishment EstablishmentDTOtoEstablishment(this EstablishmentDTO establishmentDTO)
    {
        return new Establishment
        {
            // Do not set Id here
            Name = establishmentDTO.Name,
            Address = establishmentDTO.Address,
            Contact = establishmentDTO.Contact,
            Email = establishmentDTO.Email,
            Municipality = new Municipality { Id = establishmentDTO.MunicipalityId }, // Ensure Municipality exists
            Category = establishmentDTO.Category,
            Status = establishmentDTO.Status,
            DateCreated = establishmentDTO.DateCreated
        };
    }
}