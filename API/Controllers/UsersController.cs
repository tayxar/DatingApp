using Microsoft.AspNetCore.Mvc;

using API.Entities;
using API.Data;

namespace API.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;
    
    public UsersController(DataContext context){
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
        var users = await _context.Users.ToListAsync();
        return users;
    }

    [HttpGet("{id}")] // /api/users/2
    public async Task<ActionResult<AppUser>> GetUser(int id){
        var users = await _context.Users.FindAsync(id);
        return users;
    }

}