using Domain;
using EfcDataAccess.DAOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ToyController : ControllerBase
{
    private readonly ToyDAO dao;

    public ToyController(ToyDAO dao)
    {
        this.dao = dao;
    }
    
    [HttpPost]
    public async Task<ActionResult<Toy>> CreateAsync(Toy creatingToy)
    {
        try
        {
            Toy toy = await dao.CreateAsync(creatingToy);
            return Created($"/toys/{toy.Id}", toy);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}