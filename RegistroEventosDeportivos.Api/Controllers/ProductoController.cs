
using Microsoft.AspNetCore.Mvc;
using RegistroEventosDeportivos.Application.Services;
using RegistroEventosDeportivos.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistroEventosDeportivos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoService _productoService;

        public ProductoController(ProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            var productos = await _productoService.GetProductosAsync();
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = await _productoService.GetProductoByIdAsync(id);
            if (producto == null) return NotFound();
            return Ok(producto);
        }

        [HttpPost]
        public async Task<ActionResult> AddProducto(Producto producto)
        {
            await _productoService.AddProductoAsync(producto);
            return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, producto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProducto(int id, Producto producto)
        {
            if (id != producto.Id) return BadRequest();
            await _productoService.UpdateProductoAsync(producto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProducto(int id)
        {
            await _productoService.DeleteProductoAsync(id);
            return NoContent();
        }
    }
}
