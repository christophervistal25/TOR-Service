using TOR.API.Models;
using TOR.API.DTOs;

namespace TOR.API.Mappers;

public static class AccomodationClassificationMapper
{
    public static AccomodationClassificationDTO ToDTO(this AccomodationClassification classification)
    {
        return new AccomodationClassificationDTO
        {
            Id = classification.Id,
            Name = classification.Name,
            Code = classification.Code,
            Status = classification.Status,
            DateCreated = classification.DateCreated
        };
    }

    public static AccomodationClassification ToEntity(this AccomodationClassificationDTO classificationDTO)
    {
        return new AccomodationClassification
        {
            Id = classificationDTO.Id,
            Name = classificationDTO.Name,
            Code = classificationDTO.Code,
            Status = classificationDTO.Status,
            DateCreated = classificationDTO.DateCreated,
        };
    }
}