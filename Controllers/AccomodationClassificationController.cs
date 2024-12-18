using Microsoft.AspNetCore.Mvc;
using TOR.API.DTOs;
using TOR.API.Interfaces;
using TOR.API.Mappers;
using TOR.API.Models;

namespace TOR.API.Controllers;

[Route("/api/accomodationclassification")]
[ApiController]
public class AccomodationClassificationController : ControllerBase
{
    private readonly IAccomodationClassificationRepository _classificationRepository;

    public AccomodationClassificationController(IAccomodationClassificationRepository classificationRepository)
    {
        _classificationRepository = classificationRepository;
    }

    [HttpGet]
    [Route("paginated")]
    public async Task<IActionResult> GetPaginated([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string searchTerm = "")
    {
        var (accomodation, totalCount) = await _classificationRepository.GetPaginatedAsync(pageNumber, pageSize, searchTerm);
        var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

        var response = new PaginatedResponseDTO<AccomodationClassificationDTO>
        {
            TotalCount = totalCount,
            TotalPages = totalPages,
            currentPage = pageNumber,
            term = searchTerm,
            Data = accomodation.Select(x => x.ToDTO()).ToList()
        };

        return Ok(response);
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var classifications = await _classificationRepository.GetAllAsync();
        return Ok(classifications.Select(c => c.ToDTO()));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var classification = await _classificationRepository.GetByIdAsync(id);
        if (classification == null) return NotFound();
        return Ok(classification.ToDTO());
    }
    
    

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AccomodationClassificationDTO classificationDTO)
    {
        var classification = classificationDTO.ToEntity();
        await _classificationRepository.AddAsync(classification);
        return CreatedAtAction(nameof(GetById), new { id = classification.Id }, classification.ToDTO());
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] AccomodationClassificationDTO classificationDTO)
    {
        var classification = classificationDTO.ToEntity();
        var updatedClassification = await _classificationRepository.UpdateAsync(id, classification);
        if (updatedClassification == null) return NotFound();
        return Ok(updatedClassification.ToDTO());
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var classification = await _classificationRepository.DeleteAsync(id);
        if (classification == null) return NotFound();
        return Ok(classification.ToDTO());
    }
}