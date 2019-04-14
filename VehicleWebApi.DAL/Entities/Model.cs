using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleWebApi.DAL.Entities
{
    public class Model : Entity, IEntity
    {
        public string Name { get; set; }
        public int HorsePower { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
