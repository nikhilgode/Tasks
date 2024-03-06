using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalMovie.Dto
{
    public class CustomerDto
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsSubscribed { get; set; }
    }
}