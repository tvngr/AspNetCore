using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkSpaceApplication2.Entities;
using WorkSpaceApplication2.Model;

namespace WorkSpaceApplication2.Repositories
{
    public class StudentRepository
    {
        private WorkSpaceApplication2DBContext _db = new WorkSpaceApplication2DBContext();
        public void Add(string fname,string lname)
        {
            Student student = new Student()
            {
                FirstName=fname,
                LastName=lname
            };
            _db.Students.Add(student);
            _db.SaveChanges();
        }
        public IList<Student> GetList()
        {
            return _db.Students.ToList();
        }
    }
}
