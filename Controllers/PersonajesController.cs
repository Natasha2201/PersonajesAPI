using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonajesAPI.Data;
using PersonajesAPI.Models;

[ApiController]
[Route("api/[controller]")]
public class PersonajesController : ControllerBase
{
    private readonly AppDbContext _context;

    public PersonajesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Personaje>>> Get()
    {
        return await _context.Personajes.ToListAsync();
    }

    [HttpPost]
    public async Task<IActionResult> Post(Personaje personaje)
    {
        _context.Personajes.Add(personaje);
        await _context.SaveChangesAsync();
        return Ok(personaje);
    }
}
