using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Prometheus;

namespace MiApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        // Simulación de una base de datos en memoria
        private static List<Producto> productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Producto 1", Precio = 100 },
            new Producto { Id = 2, Nombre = "Producto 2", Precio = 200 },
            new Producto { Id = 3, Nombre = "Producto 3", Precio = 300 }
        };

        private static readonly Counter _requestCounter = Metrics.CreateCounter("example_requests_total", "Total number of requests");
        // GET: api/productos
        [HttpGet]
        public IActionResult GetProductos()
        {
            // Incrementar el contador cada vez que se llama al endpoint
            _requestCounter.Inc();

            return Ok(productos);
        }

        // GET: api/productos/{id}
        [HttpGet("{id}")]
        public IActionResult GetProductoById(int id)
        {
            // Incrementar el contador cada vez que se llama al endpoint
            _requestCounter.Inc();
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound(new { mensaje = "Producto no encontrado" });
            }
            return Ok(producto);
        }

        // POST: api/productos
        [HttpPost]
        public IActionResult CrearProducto([FromBody] Producto nuevoProducto)
        {
            // Incrementar el contador cada vez que se llama al endpoint
            _requestCounter.Inc();

            nuevoProducto.Id = productos.Count + 1;
            productos.Add(nuevoProducto);
            return CreatedAtAction(nameof(GetProductoById), new { id = nuevoProducto.Id }, nuevoProducto);
        }

        // PUT: api/productos/{id}
        [HttpPut("{id}")]
        public IActionResult ActualizarProducto(int id, [FromBody] Producto productoActualizado)
        {
            // Incrementar el contador cada vez que se llama al endpoint
            _requestCounter.Inc();

            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound(new { mensaje = "Producto no encontrado" });
            }
            producto.Nombre = productoActualizado.Nombre;
            producto.Precio = productoActualizado.Precio;
            return NoContent();
        }

        // DELETE: api/productos/{id}
        [HttpDelete("{id}")]
        public IActionResult EliminarProducto(int id)
        {
            // Incrementar el contador cada vez que se llama al endpoint
            _requestCounter.Inc();

            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound(new { mensaje = "Producto no encontrado" });
            }
            productos.Remove(producto);
            return NoContent();
        }
    }

    // Clase modelo para los productos
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}
