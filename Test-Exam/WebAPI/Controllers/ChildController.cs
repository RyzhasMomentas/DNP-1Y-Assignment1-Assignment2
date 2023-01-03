using Domain;
using EfcDataAccess.DAOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ChildController : ControllerBase
{
    private readonly ChildDAO dao;

    public ChildController(ChildDAO dao)
    {
        this.dao = dao;
    }
    
    [HttpPost]
    public async Task<ActionResult<Child>> CreateAsync(Child creatingChild)
    {
        try
        {
            Child child = await dao.CreateAsync(creatingChild);
            return Created($"/children/{child.Id}", child);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}