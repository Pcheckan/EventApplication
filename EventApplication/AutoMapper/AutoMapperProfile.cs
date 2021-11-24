using AutoMapper;
using EventApplication.Models;
using EventApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventApplication.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Users, UsersVM>().ReverseMap(); 
        }
    }
}
