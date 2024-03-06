using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalMovie.Dto
{
    public class NewRental
    {
        int Id { get; set; }

        List<int> MovieId { get; set; }
    }
}