using Microsoft.EntityFrameworkCore;
using VehicleWebApi.DAL.Entities;

namespace VehicleWebApi.DAL.Context
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options)
            : base(options)
        {
        }

        public DbSet<Model> Models { get; set; }
    }
}
