using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleWebApi.DAL.Entities
{
    public interface IEntity
    {
        int? Id { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateUpdated { get; set; }
    }
}
