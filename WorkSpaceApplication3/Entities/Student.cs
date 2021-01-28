using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkSpaceApplication2.Entities
{
    public class Student:Pesron
    {
        public Student()
        {

        }
        public Student(string FirstName, string LastName)
        {
            FirstName = FirstName;
            LastName = LastName;
            Courses = new List<Course>();
        }
        [Key]
        public int StudentID { get; set; }
        public List<Course> Courses { get; set; }

    }
}
