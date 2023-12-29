using Resources.API.Entities;

namespace Resources.API.Services
{
    public interface ICityInfoRepository
    {
        Task<bool> CityExists(int cityId);
        Task<IEnumerable<City>> GetCitiesAsync();
        Task<City>? GetCityAsync(int cityId, bool includePointsOfInterest);
        Task<PointOfInterest>? GetPointOfInterestForCityAsync(int cityId,
            int pointOfInterestId);
        Task<IEnumerable<PointOfInterest>>? GetPointsOfInterestForCityAsync(int cityId);
        Task AddPointOfInterestForCityAsync(int cityId, PointOfInterest pointOfInterest);
        void DeletePointOfInterest(PointOfInterest pointOfInterest);
        Task<bool> SaveChangesAsync();
    }
}
