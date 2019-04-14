using System;
using System.Collections.Generic;
using System.Text;
using VehicleWebApi.DTO.DTO.Interfaces;

namespace VehicleWebApi.DTO.DTO
{
    public class ModelDto : BaseDto
    {
        public string Name { get; set; }
        public int HorsePower { get; set; }
        public ManufacturerDto Manufacturer { get; set; }
    }
}
