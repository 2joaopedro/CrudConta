using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CrudConta.Entities;
using CrudConta.Persistence;
namespace CrudConta.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase {
        private readonly ApiDbContext _context;
        public Controller(ApiDbContext context) 
        {
            _context = context;
        }

        // Crud Para Conta
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAll() 
        {
            // Retornar todas as contas da base
            var contas = _context.Conta.ToList();
            return Ok(contas);
        }

        [HttpGet("{id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
    }
}