using System;
using System.ComponentModel.DataAnnotations;

namespace WorkSpaceApplication2.Entities
{
    public class MyLog
    {
        [Key]
        public int Id { get; set; }
        public string EntitiName { get; set; }
        public string ActionName { get; set; }
        public int userId { get; set; }
        public DateTime CreDate { get; set; }
    }
}
