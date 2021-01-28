using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkSpaceApplication2.Entities
{
    public class Teacher:Pesron
    {
        public Teacher(string FirstName, string LastName)
        {
            FirstName = FirstName;
            LastName = LastName;
        }
        [Key]
        public int TeacherID { get; set; }
    }
}
