using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityCustomerMVC.Models
{
    public class City
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
    }
}