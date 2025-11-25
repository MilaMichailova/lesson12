using Microsoft.AspNetCore.Mvc;
using lesson12.Dto;

namespace lesson12.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<ProductDto> _products = new();

    [HttpPost]
    public IActionResult CreateProduct([FromBody] ProductDto product)
    {
        // Валидация происходит автоматически благодаря [ApiController]
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _products.Add(product);
        return CreatedAtAction(nameof(GetProduct), new { id = _products.Count }, product);
    }

    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        if (id <= 0 || id > _products.Count)
            return NotFound();
        return Ok(_products[id - 1]);
    }
}