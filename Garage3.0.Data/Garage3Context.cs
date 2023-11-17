using Garage3._0.Domain;
using Microsoft.EntityFrameworkCore;

namespace Garage3._0.Data
{
    public class Garage3Context:DbContext

    {
        public DbSet<Member> UserMember { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        public DbSet<VehicleType> VehicleType { get; set; }

        public DbSet<ParkingSpot> ParkingSpot { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer
        }

    }
}
