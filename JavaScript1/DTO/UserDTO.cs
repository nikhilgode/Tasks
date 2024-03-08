using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JavaScript1.DTO
{
    public class UserDTO
    {
       
            public int Id { get; set; }
            public string First_Name { get; set; }

            public string Last_Name { get; set; }
            public string Email { get; set; }
        
    }
}