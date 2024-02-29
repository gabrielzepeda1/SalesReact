using DB.Data;
using DB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly DbFacturacionContext _context;
        public RolesController(DbFacturacionContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Rol>>> GetRoles()
        {
            var roles = await _context.Roles.ToListAsync();

            return Ok(roles);
        }

        [HttpGet("{id}")] //api/roles/1
        public async Task<ActionResult<Rol>> GetRol(int id)
        {
            return await _context.Roles.FindAsync(id);
        }
    }
}