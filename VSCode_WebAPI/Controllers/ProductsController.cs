using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VSCode_WebAPI.Data;
using VSCode_WebAPI.Models;

namespace VSCode_WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly MyProductsContext _context;

        public ProductsController(MyProductsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAll() => _context.Products.ToList();

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(long id)
        {
            var product = await _context.Products.FindAsync(id);

            return product == null ? (ActionResult<Product>)NotFound() : (ActionResult<Product>)product;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Create(Product product)
        {
            _context.Products.Add(product);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }
    }

}