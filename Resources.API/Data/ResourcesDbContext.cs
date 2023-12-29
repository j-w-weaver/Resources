using Microsoft.EntityFrameworkCore;
using Resources.API.Controllers;
using Resources.API.Entities;

namespace Resources.API.Data
{
    public class ResourcesDbContext : DbContext
    {
        public ResourcesDbContext(DbContextOptions<ResourcesDbContext> options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City("Sarasota")
                {
                    Id = 1,
                    Description = "City just south of Tampa.",
                },
                new City("Tampa")
                {
                    Id = 2,
                    Description = "City just north of Sarasota.",
                },
                new City("Venice")
                {
                    Id = 3,
                    Description = "City just south of Sarasota.",
                }
                );
            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest("Bayfront")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "Restaurant by the Marina Jacks"
                },
                new PointOfInterest("Siesta Key")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "Very popular white sandy beach."
                },
                new PointOfInterest("Glazors Kids Museum")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "Huge indoor playground and learning facility for kids"
                },
                new PointOfInterest("St. Petes Beach")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "Very popular beach."
                },
                new PointOfInterest("Sharkys")
                {
                    Id = 5,
                    CityId = 3,
                    Description = "Restaurant right on the Venice beach."
                },
                new PointOfInterest("Venice Beach")
                {
                    Id = 6,
                    CityId = 3,
                    Description = "Very popular beach with shark teeth"
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
