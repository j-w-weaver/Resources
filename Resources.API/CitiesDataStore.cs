using Resources.API.Models;

namespace Resources.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore(); 
        public CitiesDataStore() 
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Sarasota",
                    Description = "South of Tampa",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Bayfront",
                            Description = "Restaurant with sand"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Siesta Key",
                            Description = "Popular Beach"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Tampa",
                    Description = "North of Tampa",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Bayfront Tampa",
                            Description = "Restaurant with sand"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "St Petes",
                            Description = "Popular Beach"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Venice",
                    Description = "South of Sarasota",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Sharkys",
                            Description = "Restaurant with sand"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Venice Beach",
                            Description = "Popular Beach"
                        }
                    }
                }
            };
        }

    }
}
