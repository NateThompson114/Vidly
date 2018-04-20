using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Customer, CustomerDto>();
                config.CreateMap<CustomerDto, Customer>()
                    .ForMember(m => m.Id, opt => opt.Ignore());

                config.CreateMap<Movie, MovieDto>();
                config.CreateMap<MovieDto, Movie>()
                    .ForMember(m => m.Id, opt => opt.Ignore());
            });
        }
    }
}