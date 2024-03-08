using AutoMapper;
using AutoMapper.QueryableExtensions;
using JavaScript1.DTO;
using JavaScript1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace JavaScript1.Controllers
{
    public class UserController : ApiController
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<User> GetUsers() 
        {
             using(var _context = new javascript1context()) 
             {
                var u = _context.users.ToList();
                return u;
             }
        }

     //   [HttpGet]
        //public IEnumerable<UserDTO> GetAllUsers1()
        //{
            
        //  using(var _context = new javascript1context())
        //    {

        //        var users = _context.users.ToList();
        //        var userDTOs = _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(users);
        //        return userDTOs;


        //    }
        //}
      
    }
}
//var u1 = u.Select(x => AutoMapper.Mapper.Map<UserDTO>(u));

//  var u1 = u.ToList().Select(AutoMapper.Mapper.Map<User, UserDTO>);

//var u1 = _context.users.ToList()
//                       .Select(AutoMapper.Mapper.Map<User, UserDTO>);

//return u1;
//IMapper mapper = new Mapper();
//var userDTOs = _context.users.ProjectTo<UserDTO>();
//return userDTOs.ToList();