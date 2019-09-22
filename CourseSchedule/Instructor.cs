//Copyright(c) Christopher Aram Swayne

using System;
namespace CourseSchedule
{
    public class Instructor
    {
        public string Name { get; private set; }
        public Course[] PreferredCourses { get; private set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Instructor()
        {
            Name = "";
            PreferredCourses = null;
        }

        /// <summary>
        /// Constructor where information is separated, and easier for the
        /// program to compile information together.
        /// Passes in Instructor name
        /// Passed in Instructor's preferred courses to teach.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="preferredCourseList"></param>
        public Instructor(string name, Course[] preferredCourseList)
        {
            Name = name;
            PreferredCourses = preferredCourseList;
            Console.WriteLine("Created Instructor:" + Name);
            Console.WriteLine("Preferred Course List:");
            foreach (Course course in PreferredCourses)
            {
                Console.WriteLine(course);
            }
        }

        /// <summary>
        /// Constructor where all the Instructor's information, the preferred course
        /// list and their name are in one string.
        /// </summary>
        /// <param name="details"></param>
        public Instructor(string details)
        {

        }

        
    }
}
