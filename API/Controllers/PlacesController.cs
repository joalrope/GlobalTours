using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PlacesController : ControllerBase
  {
    private readonly IPlaceRepository _repo;

    public PlacesController(IPlaceRepository repo)
    {
      _repo = repo;

    }

    [HttpGet]
    public async Task<ActionResult<List<Place>>> GetPlaces()
    {
      var Places = await _repo.GetPlacesAsync();
      return Ok(Places);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Place>> GetPlace(int id)
    {
      var Place = await _repo.GetPlaceAsync(id);
      return Ok(Place);
    }
  }
}