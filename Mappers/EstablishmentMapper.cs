using TOR.API.DTOs;
using TOR.API.Models;

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
            Municipality = new MunicipalityDTO 
            {
                Id = establishment.Municipality.Id,
                Name = establishment.Municipality.Name
            },
            Status = establishment.Status,
            DateCreated = establishment.DateCreated,
            AccomodationClassificationId = (int)establishment.AccomodationClassificationId!,
            AccomodationClassification = new AccomodationClassificationDTO
            {
                Id = (int)establishment.AccomodationClassificationId,
                Name = establishment.AccomodationClassification.Name,
                Code = establishment.AccomodationClassification.Code,
            }
        };
    }

    public static SimpleEstablishmentDTO EstablistmentToSimpleDTO(this Establishment establishment)
    {
        return new SimpleEstablishmentDTO
        {
            Id = establishment.Id,
            Name = establishment.Name,
            Address = establishment.Address,
            Contact = establishment.Contact,
            Email = establishment.Email,
            Status = establishment.Status,
            DateCreated = establishment.DateCreated,
            AccomodationClassification = new AccomodationClassificationDTO
            {
                Id = establishment.AccomodationClassificationId,
                Name = establishment.AccomodationClassification.Name,
                Code = establishment.AccomodationClassification.Code,
            }
        };
    }
    
    public static Establishment EstablishmentDTOtoEstablishment(this EstablishmentDTO establishmentDTO)
    {
        return new Establishment
        {
            Id = establishmentDTO.Id,
            Name = establishmentDTO.Name,
            Address = establishmentDTO.Address,
            Contact = establishmentDTO.Contact,
            Email = establishmentDTO.Email,
            Municipality = new Municipality
            {
                Id = establishmentDTO.MunicipalityId,
                Name = establishmentDTO.Municipality!.Name,
            },
            Status = establishmentDTO.Status,
            DateCreated = establishmentDTO.DateCreated,
            AccomodationClassificationId = establishmentDTO.AccomodationClassificationId,
            AccomodationClassification = new AccomodationClassification
            {
                Id = establishmentDTO.AccomodationClassificationId,
                Name = establishmentDTO.AccomodationClassification!.Name,
                Code = establishmentDTO.AccomodationClassification.Code,
            }
        };
    }
}