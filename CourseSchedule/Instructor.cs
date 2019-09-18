using System;
namespace CourseSchedule
{
    public class Instructor
    {
        public string Name { get; private set; }
        public Course[] PreferredCourses { get; private set; }


        public Instructor()
        {
        }
    }
}
