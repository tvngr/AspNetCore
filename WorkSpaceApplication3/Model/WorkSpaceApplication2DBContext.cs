using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkSpaceApplication2.Entities;

namespace WorkSpaceApplication2.Model
{
    public class WorkSpaceApplication2DBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDb;Integrated Security=true; Initial Catalog =WorkSpaceApplicationDb;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<MyLog> MyLogs { get; set; }
        

    }
}
