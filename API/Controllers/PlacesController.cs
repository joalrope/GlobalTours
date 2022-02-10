using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PlacesController : ControllerBase
  {
    private readonly ApplicationDbContext _db;
    public PlacesController(ApplicationDbContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Place>>> GetPlaces()
    {

      var Places = await _db.Place.ToListAsync();
      return Ok(Places);
    }

    [HttpGet("{id}")]
    public string GetPlace(int id)
    {
      var Place = _db.Place.First(id);
      return $"Retornara el lugar con Id: {id}";
    }
  }
}