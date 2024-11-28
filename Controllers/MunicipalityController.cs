using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TOR.API.Data;
using TOR.API.DTOs;
using TOR.API.Interfaces;
using TOR.API.Mappers;
using TOR.API.Models;

namespace TOR.API.Controllers;


[Route("/api/municipality")]
[ApiController]
public class MunicipalityController : ControllerBase
{
    private readonly IMunicipalityRepository _municipalityRepository;
    public MunicipalityController(IMunicipalityRepository municipalityRepository)
    {
        _municipalityRepository = municipalityRepository;
    }
    
    
    [HttpGet]
    [Route("paginated")]
    public async Task<IActionResult> GetPaginated([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string searchTerm = "")
    {
        var (municipalities, totalCount) = await _municipalityRepository.GetPaginatedAsync(pageNumber, pageSize, searchTerm);
        var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

        var response = new PaginatedResponseDTO<MunicipalityDTO>
        {
            TotalCount = totalCount,
            TotalPages = totalPages,
            currentPage = pageNumber,
            term = searchTerm,
            Data = municipalities.Select(x => x.MunicipalityToDTO()).ToList()
        };

        return Ok(response);
    }
    
    
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Get()
    {
        var municipalities = await _municipalityRepository.GetAllAsync();
        return Ok(municipalities.Select(x => x.MunicipalityToDTO()));
    }
    
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var municipality = await _municipalityRepository.GetByIdAsync(id);
        return Ok(municipality.MunicipalityToDTO());
    }
    
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] MunicipalityDTO municipality)
    {
        var Municipality = municipality.MunicipalityDTOtoMunicipality();
        await _municipalityRepository.AddAsync(Municipality);
        return CreatedAtAction(nameof(GetById), new { id = municipality.Id }, Municipality);
    }
    
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> Update([FromRoute] int id, MunicipalityDTO municipality)
    {
        var data = await _municipalityRepository.UpdateAsync(id, municipality.MunicipalityDTOtoMunicipality());
        return Ok(data.MunicipalityToDTO());
    }
    
    
    // delete endpoint
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var data = await _municipalityRepository.DeleteAsync(id);
        return Ok(data.MunicipalityToDTO());
    }
    

}