using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleWebApi.DTO.DTO
{
    public class ManufacturerDto : BaseDto
    {
        public string Name { get; set; }
        public List<ModelDto> Models { get; set; }
    }
}
