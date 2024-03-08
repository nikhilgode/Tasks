using AutoMapper;
using JavaScript1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JavaScript1.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
          //  Mapper.CreateMap<User, DTO.UserDTO>();
            CreateMap<User, DTO.UserDTO>();
        }
    }
}