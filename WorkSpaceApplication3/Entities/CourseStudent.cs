namespace WorkSpaceApplication2.Entities
{
    public class CourseStudent
    {
        public int CourseStudentID { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }        
    }
}
