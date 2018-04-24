using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly2.Dtos;
using Vidly2.Models;

namespace Vidly2.App_Start
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

                config.CreateMap<MembershipType, MembershipTypeDto>();

                config.CreateMap<Genre, GenreDto>();
            });
        }
    }
}