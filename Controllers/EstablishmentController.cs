using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TOR.API.DTOs;
using TOR.API.Interfaces;
using TOR.API.Mappers;
using TOR.API.Models;
using TOR.API.Repositories;

namespace TOR.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstablishmentController : ControllerBase
{
    private readonly IEstablishmentRepository _repository;

    public EstablishmentController(IEstablishmentRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    [Authorize]
    [Route("paginated")]
    public async Task<IActionResult> GetPaginated([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string searchTerm = "")
    {
        var (establishments, totalCount) = await _repository.GetPaginatedAsync(pageNumber, pageSize, searchTerm);
        var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

        var response = new PaginatedResponseDTO<EstablishmentDTO>
        {
            TotalCount = totalCount,
            
            TotalPages = totalPages,
            currentPage = pageNumber,
            term = searchTerm,
            Data = establishments.Select(x => x.EstablishmentToDTO()).ToList()
        };

        return Ok(response);
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Get()
    {
        var establishments = await _repository.GetAllAsync();
        return Ok(establishments.Select(e => e.EstablishmentToDTO()));
    }
    



    [HttpGet("{id}")]
    public async Task<ActionResult<EstablishmentDTO>> GetEstablishment(int id)
    {
        var establishment = await _repository.GetByIdAsync(id);
        if (establishment == null)
        {
            return NotFound();
        }

        return Ok(establishment.EstablishmentToDTO());
    }
    
    
    [HttpGet("/api/Establishment/municipality/{id}")]
    public async Task<ActionResult<EstablishmentDTO>> GetEstablishmentByMunicipality(int id)
    {
        var establishment = await _repository.GetEstablishmentByMunicipality(id);

        return Ok(establishment.Select(e => e.EstablistmentToSimpleDTO()));
    }

    [HttpPost]
    public async Task<ActionResult<EstablishmentDTO>> CreateEstablishment(EstablishmentDTO establishmentDTO)
    {
        var establishment = establishmentDTO.EstablishmentDTOtoEstablishment();
        await _repository.AddAsync(establishment);
        return CreatedAtAction(nameof(GetEstablishment), new { id = establishment.Id }, establishment.EstablishmentToDTO());
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEstablishment(int id, EstablishmentDTO establishmentDTO)
    {
        if (id != establishmentDTO.Id)
        {
            return BadRequest();
        }

        await _repository.UpdateAsync(id, establishmentDTO.EstablishmentDTOtoEstablishment());
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEstablishment(int id)
    {
        await _repository.DeleteAsync(id);
        return NoContent();
    }
}