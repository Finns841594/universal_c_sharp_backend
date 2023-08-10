using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace puppiesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PuppiesController : ControllerBase
{
    private readonly MvcDataContext _context;

    public PuppiesController(MvcDataContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetPuppies")]
    public async Task<ActionResult<IEnumerable<Puppy>>> GetPuppies()
    {
        if (_context.Puppies == null)
          {
              return NotFound();
          }
          var puppies = await _context.Puppies.ToListAsync();
          return Ok(puppies);
    }
    [HttpGet("/GetBears")]
    public async Task<ActionResult<IEnumerable<Bear>>> GetBears()
    {
        if (_context.Bears == null)
          {
              return NotFound();
          }
          var Bears = await _context.Bears.ToListAsync();
          return Ok(Bears);
    }

}
