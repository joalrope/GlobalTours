using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
  public class PlaceRepository : IPlaceRepository
  {
    private readonly ApplicationDbContext _db;
    public PlaceRepository(ApplicationDbContext db)
    {
      _db = db;

    }

    public async Task<Place> GetPlaceAsync(int id)
    {
      return await _db.Place.FindAsync(id);
    }

    public async Task<IReadOnlyList<Place>> GetPlacesAsync()
    {
      return await _db.Place.ToListAsync();
    }
  }
}