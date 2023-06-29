using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository repo;

        public ProductsController(IProductRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await repo.GetAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await repo.GetAsync(id);
        }
    }
}
