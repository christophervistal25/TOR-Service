using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using TOR.API.DTOs;

namespace TOR.API.Interfaces;

public interface ITokenService
{
    string CreateToken(User user);
    bool ValidateToken(string token);
    ClaimsDTO DecodeToken(string token);
}