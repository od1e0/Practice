using Task2.Models;
using Microsoft.EntityFrameworkCore;

namespace Task2.Data
{
    public class TourDbContext : DbContext
    {
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Tourist> Tourists { get; set; }

        public TourDbContext(DbContextOptions<TourDbContext> options) : base(options)
        {
        }
    }
}