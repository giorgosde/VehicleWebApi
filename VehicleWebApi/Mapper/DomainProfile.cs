using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleWebApi.DAL.Entities;
using VehicleWebApi.DTO.DTO;

namespace VehicleWebApi.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<ModelDto, Model>();
            CreateMap<Model, ModelDto>();

            CreateMap<ManufacturerDto, Manufacturer>();
            CreateMap<Manufacturer, ManufacturerDto>();
        }
    }
}
