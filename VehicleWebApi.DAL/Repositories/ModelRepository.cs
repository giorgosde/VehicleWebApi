using System;
using System.Collections.Generic;
using System.Text;
using VehicleWebApi.DAL.Context;
using VehicleWebApi.DAL.Entities;

namespace VehicleWebApi.DAL.Repositories
{
    public class ModelRepository : Repository<Model>, IModelRepository
    {
        public ModelRepository(VehicleContext context) : base(context)
        {
        }
    }
}
