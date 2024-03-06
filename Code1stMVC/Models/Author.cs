using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code1stMVC.Models
{
    public class Author
    {
        public int id { get; set; }

        public string name { get; set; }

        public IList<Course> Courses { get; set; }

    }

}