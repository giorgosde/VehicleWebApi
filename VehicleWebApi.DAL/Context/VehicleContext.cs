using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
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
