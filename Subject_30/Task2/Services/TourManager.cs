using Task2.Data;
using Task2.Models;
using Microsoft.EntityFrameworkCore;

namespace Task2.Services
{
    internal class TourManager
    {
        private readonly string connectionString;

        public TourManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private TourDbContext GetDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TourDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new TourDbContext(optionsBuilder.Options);
        }

        public List<Tour> GetTours()
        {
            using (var context = GetDbContext())
            {
                return context.Tours.ToList();
            }
        }

        public void AddTour(string tourName)
        {
            using (var context = GetDbContext())
            {
                var tour = new Tour { TourName = tourName };
                context.Tours.Add(tour);
                context.SaveChanges();
            }
        }

        public void DeleteTour(int tourId)
        {
            using (var context = GetDbContext())
            {
                var tour = context.Tours.FirstOrDefault(t => t.TourId == tourId);
                if (tour != null)
                {
                    context.Tours.Remove(tour);
                    context.SaveChanges();
                }
            }
        }

        public void AddTourist(string touristName)
        {
            using (var context = GetDbContext())
            {
                var tourist = new Tourist { Name = touristName};
                context.Tourists.Add(tourist);
                context.SaveChanges();
            }
        }

        public void UpdateTouristName(int touristId, string updatedName)
        {
            using (var context = GetDbContext())
            {
                var tourist = context.Tourists.FirstOrDefault(t => t.TouristId == touristId);
                if (tourist != null)
                {
                    tourist.Name = updatedName;
                    context.SaveChanges();
                }
            }
        }
    }
}
