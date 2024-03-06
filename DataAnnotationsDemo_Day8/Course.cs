using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationsDemo_Day8
{
    public class Course
    {

        public Course() 
        {
           tags =new HashSet<Tag>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Tag> tags { get; set; }

        public Cover cover { get; set; }
    }
}
