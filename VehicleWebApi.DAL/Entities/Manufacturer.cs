using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleWebApi.DAL.Entities
{
    public class Manufacturer : Entity
    {
        public string Name { get; set; }
        public List<Model> Models { get; set; }
    }
}
