using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIData.DataContext;
using APIData.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = _context.Products.ToList();
            return data;
        }
        [HttpGet("id")]
        public async Task<ActionResult<>>
    }
}
