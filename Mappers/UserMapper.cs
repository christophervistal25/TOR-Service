using TOR.API.Models;
using TOR.API.DTOs;

namespace TOR.API.Mappers;

public static class UserMapper
{
    public static UserDTO ToDTO(this User user)
    {
        return new UserDTO
        {
            Id = user.Id,
            Firstname = user.Firstname,
            Middlename = user.Middlename,
            Lastname = user.Lastname,
            Username = user.UserName,
            Suffix = user.Suffix,
            Email = user.Email,
            Contact = user.Contact,
            AccountType = user.AccountType.ToUpper(),
            Status = user.Status,
            DateCreated = user.DateCreated,
            MunicipalityId = user.Municipality?.Id,
            EstablishmentId = user.Establishment?.Id,
            Municipality = user.MunicipalityId.HasValue
                ? new MunicipalityDTO()
                {
                    Id = user.Municipality?.Id ?? 0,
                    Name = user.Municipality?.Name,
                    Province = user.Municipality?.Province,
                }
                : null,
            Establishment = user.EstablishmentId.HasValue
                ? new EstablishmentDTO()
                {
                    Id = user.Establishment?.Id ?? 0,
                    Name = user.Establishment?.Name,
                    Address = user.Establishment?.Address,
                    Contact = user.Establishment?.Contact,
                }
                : null
        };
    }

    public static User ToEntity(this UserDTO userDTO)
    {
        return new User
        {
            Id = userDTO.Id,
            Firstname = userDTO.Firstname,
            Middlename = userDTO.Middlename,
            Lastname = userDTO.Lastname,
            UserName = userDTO.Username,
            Suffix = userDTO.Suffix,
            Email = userDTO.Email,
            Contact = userDTO.Contact,
            AccountType = userDTO.AccountType.ToUpper(),
            Status = userDTO.Status,
            DateCreated = userDTO.DateCreated,
            MunicipalityId = userDTO.MunicipalityId,
            EstablishmentId = userDTO.EstablishmentId,
        };
    }
}