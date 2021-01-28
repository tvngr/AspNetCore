using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkSpaceApplication2.Entities;
using WorkSpaceApplication2.Model;

namespace WorkSpaceApplication2.Repositories
{
    public class MyLoggerRepository
    {
        private WorkSpaceApplication2DBContext db = new WorkSpaceApplication2DBContext();
        public void Add(string Cname,String Aname,string Usernamne)
        {
            MyLog myLog = new MyLog()
            {
                ActionName = Aname,
                EntitiName = Cname,
                CreDate = DateTime.Now,
                userId = 1,
            };
            db.MyLogs.Add(myLog);
            db.SaveChanges();
        }
    }
}
