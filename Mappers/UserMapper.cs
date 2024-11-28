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
            Suffix = user.Suffix,
            Email = user.Email,
            Contact = user.Contact,
            AccountType = user.AccountType,
            Status = user.Status,
            DateCreated = user.DateCreated,
            MunicipalityId = user.Municipality?.Id,
            EstablishmentId = user.Establishment?.Id,
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
            Suffix = userDTO.Suffix,
            Email = userDTO.Email,
            Contact = userDTO.Contact,
            AccountType = userDTO.AccountType,
            Status = userDTO.Status,
            DateCreated = userDTO.DateCreated,
            MunicipalityId = userDTO.MunicipalityId,
            EstablishmentId = userDTO.EstablishmentId,
        };
    }
}