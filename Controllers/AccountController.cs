using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TOR.API.DTOs;
using TOR.API.Interfaces;
using TOR.API.Mappers;

namespace TOR.API.Controllers;

[Route("/api/account")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly ITokenService _tokenService;
    private readonly SignInManager<User> _signInManager;

    public AccountController(UserManager<User> userManager, ITokenService tokenService, SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _signInManager = signInManager;
    }

    
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
    {
        try
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == loginDTO.Email);
            if (user == null)
            {
                return Unauthorized("Invalid email or password");
            }
    
            var result = _signInManager.CheckPasswordSignInAsync(user, loginDTO.Password, false);
            if (!result.Result.Succeeded)
            {
                return Unauthorized("Invalid email or password");
            }

            return Ok(new NewUserDTO()
            {
                Email = user.Email,
                Username = user.UserName,
                Token = _tokenService.CreateToken(user)
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    
    
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
    {
        try
        {
            var user = new User
            {
                Firstname = registerDTO.Firstname,
                Middlename = registerDTO.Middlename,
                Lastname = registerDTO.Lastname,
                Suffix = registerDTO.Suffix,
                Email = registerDTO.Email,
                Contact = registerDTO.Contact,
                UserName = registerDTO.Email,
                AccountType = registerDTO.AccountType,
                Status = registerDTO.Status,
                DateCreated = DateTime.UtcNow,
                MunicipalityId = registerDTO.MunicipalityId,
                EstablishmentId = registerDTO.EstablishmentId
            };

            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            
            var result = await _userManager.CreateAsync(user, registerDTO.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            else
            {
                var roleResult = await _userManager.AddToRoleAsync(user, registerDTO.AccountType);
                if(roleResult.Succeeded)
                {
                    return Ok(new NewUserDTO()
                    {
                        Username = registerDTO.Username,
                        Email = registerDTO.Email,
                        Token = _tokenService.CreateToken(user)
                    });
                }
                else
                {
                    return StatusCode(500, roleResult.Errors);
                }
            }
            
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}