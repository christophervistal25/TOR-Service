namespace TOR.API.Interfaces;

public interface ITokenService
{
    string CreateToken(User user);
}