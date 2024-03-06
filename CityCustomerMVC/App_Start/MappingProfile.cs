using AutoMapper;
using CityCustomerMVC.Dto;
using CityCustomerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityCustomerMVC.App_Start
{
    public class MappingProfile : Profile
    {
       public MappingProfile() 
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto,Customer>();
        }
    }
}