using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorkSpaceApplication2.Entities
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
    }
}
