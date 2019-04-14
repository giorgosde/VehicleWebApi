using System;
using System.Collections.Generic;
using System.Text;
using VehicleWebApi.DTO.DTO.Interfaces;

namespace VehicleWebApi.DTO.DTO
{
    public class BaseDto : IDto
    {
        public int Id { get; set; }
    }
}
