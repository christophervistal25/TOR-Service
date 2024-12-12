using Microsoft.AspNetCore.Mvc;
using TOR.API.DTOs;
using TOR.API.Interfaces;
using TOR.API.Mappers;

namespace TOR.API.Controllers;

[Route("/api/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    // paginated
    [HttpGet]
    [Route("paginated")]
    public async Task<IActionResult> GetPaginated([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string searchTerm = "")
    {
        var (users, totalCount) = await _userRepository.GetPaginatedAsync(pageNumber, pageSize, searchTerm);
        var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

        var response = new PaginatedResponseDTO<UserDTO>
        {
            TotalCount = totalCount,
            TotalPages = totalPages,
            currentPage = pageNumber,
            term = searchTerm,
            Data = users.Select(x => x.ToDTO()).ToList()
        };

        return Ok(response);
    }
    
    
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await _userRepository.GetAllAsync();
        return Ok(users.Select(u => u.ToDTO()));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null) return NotFound();
        return Ok(user.ToDTO());
    }
    
    [HttpGet("email/{email}")]
    public async Task<IActionResult> GetByEmail(string email)
    {
        var user = await _userRepository.GetByEmailAsync(email);
        if (user == null) return NotFound();
        return Ok(user.ToDTO());
    }
    
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] UserDTO userDTO)
    {
        userDTO.Id = Guid.NewGuid().ToString();
        var user = await _userRepository.AddAsync(userDTO.ToEntity());
        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user.ToDTO());
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] UserDTO userDTO)
    {
        var user = userDTO.ToEntity();
        var updatedUser = await _userRepository.UpdateAsync(id, user);
        if (updatedUser == null) return NotFound();
        return Ok(updatedUser.ToDTO());
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var user = await _userRepository.DeleteAsync(id);
        if (user == null) return NotFound();
        return Ok(user.ToDTO());
    }
}