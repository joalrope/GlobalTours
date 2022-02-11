using Core.Entities;

namespace Core.Interfaces
{
  public interface IPlaceRepository
  {
    Task<Place> GetPlaceAsync(int id);

    Task<IReadOnlyList<Place>> GetPlacesAsync();
  }
}