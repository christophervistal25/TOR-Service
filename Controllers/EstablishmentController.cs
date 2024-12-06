using Microsoft.AspNetCore.Mvc;
using TOR.API.DTOs;
using TOR.API.Interfaces;
using TOR.API.Mappers;
using TOR.API.Models;

namespace TOR.API.Controllers;

[Route("/api/establishment")]
[ApiController]
public class EstablishmentController : ControllerBase
{
    private readonly IEstablishmentRepository _establishmentRepository;

    public EstablishmentController(IEstablishmentRepository establishmentRepository)
    {
        _establishmentRepository = establishmentRepository;
    }
    
    [HttpGet]
    [Route("paginated")]
    public async Task<IActionResult> GetPaginated([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string searchTerm = "")
    {
        var (establishments, totalCount) = await _establishmentRepository.GetPaginatedAsync(pageNumber, pageSize, searchTerm);
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
    public async Task<IActionResult> Get()
    {
        var establishments = await _establishmentRepository.GetAllAsync();
        return Ok(establishments.Select(e => e.EstablishmentToDTO()));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var establishment = await _establishmentRepository.GetByIdAsync(id);
        if (establishment == null) return NotFound();
        return Ok(establishment.EstablishmentToDTO());
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] EstablishmentDTO establishmentDTO)
    {
        var establishment = establishmentDTO.EstablishmentDTOtoEstablishment();
        await _establishmentRepository.AddAsync(establishment);
        return CreatedAtAction(nameof(GetById), new { id = establishment.Id }, establishment.EstablishmentToDTO());
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] EstablishmentDTO establishmentDTO)
    {
        var establishment = establishmentDTO.EstablishmentDTOtoEstablishment();
        var updatedEstablishment = await _establishmentRepository.UpdateAsync(id, establishment);
        if (updatedEstablishment == null) return NotFound();
        return Ok(updatedEstablishment.EstablishmentToDTO());
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var establishment = await _establishmentRepository.DeleteAsync(id);
        if (establishment == null) return NotFound();
        return Ok(establishment.EstablishmentToDTO());
    }
}