using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TOR.API.Data;
using TOR.API.DTOs;
using TOR.API.Interfaces;
using TOR.API.Mappers;
using TOR.API.Models;

namespace TOR.API.Controllers;


[Route("/api/stock")]
[ApiController]
public class StockController : ControllerBase
{
    
    private readonly IStockRepository _repository;
    public StockController(IStockRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var stocks = await _repository.GetAllAsync();
        var stockDto = stocks.Select(s => s.StockToDTO());
        return Ok(stockDto);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var stock = await _repository.GetByIdAsync(id);

        return Ok(stock.StockToDTO());
    }


    // [HttpPost]
    // public async Task<IActionResult> CreateStock([FromBody] Stock createStock)
    // {
    //     var stock = createStock.StockFromDTO();
    //     if (stock != null)
    //     {
    //         await _repository.AddAsync(stock);
    //         return CreatedAtAction(nameof(GetById), new { id = stock.Id }, stock);
    //     }
    //     return BadRequest();
    // }

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateStock([FromRoute] int id, UpdateStockDTO updateStock)
    {
        await _repository.UpdateAsync(id, updateStock.StockFromUpdateDTO());
        
        return Ok(updateStock);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteStock([FromRoute] int id)
    {
        await _repository.DeleteAsync(id);
        return NotFound();
    }
}