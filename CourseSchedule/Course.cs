//Copyright(c) Christopher Aram Swayne

using System;
namespace CourseSchedule
{
    public class Course
    {
        /// <summary>
        /// While CourseNumber is a "number" since it includes characters in a
        /// prefix, I've set it to a string.
        ///
        /// Course Size details the total number of enrolled students in the
        /// course.
        ///
        /// IsSectioned tells me if there are multiple sections of the course.
        /// SectionNumber then tells me what the Section is, whether it is the
        /// first or second, or .... etc course.
        /// </summary>
        public string CourseNumber { get; private set; }
        public int CourseEnrollment { get; private set; }
        public bool IsSectioned { get; private set; }
        public int SectionNumber { get; private set; }

        /// <summary>
        /// Initialize a course with empty and default values.
        /// </summary>
        public Course()
        {
            CourseNumber = "";
            CourseEnrollment = 0;
            IsSectioned = false;
            SectionNumber = 0;
        }


        /// <summary>
        /// Creates a course where the courses are to be initialized with non-default
        /// values.
        /// </summary>
        /// <param name="courseNumber"></param>
        /// <param name="courseEnrollment"></param>
        /// <param name="isSectioned"></param>
        public Course(string courseNumber, int courseEnrollment, bool isSectioned)
        {
            CourseNumber = courseNumber;
            CourseEnrollment = courseEnrollment;
            IsSectioned = isSectioned;

        }

        /// <summary>
        /// If a course doesn't have the required information in the right format,
        /// then this will process a string of all the information into a Course
        /// Object.
        /// </summary>
        /// <param name="courseInformation"></param>
        public void GrabCourse(string courseInformation)
        {
            string courseNum = "";
            foreach(char c in courseInformation)
            {
                if (!c.Equals(' ')))
                {
                    if (c.Equals('A'))
                    {
                        IsSectioned = true;
                        SectionNumber = 1;
                    }
                    else if (c.Equals('B'))
                    {
                        IsSectioned = true;
                        SectionNumber = 2;
                    }
                    else
                    {
                        courseNum.Insert(courseNum.Length, c.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// ToString overridden to allow for easy readability of the Course
        /// represented by a string.
        /// </summary>
        /// <returns>String representation of the course for user view.</returns>
        public override string ToString()
        {
            string temp;
            if (IsSectioned)
            {
                temp = CourseNumber + SectionNumber.ToString();
            } else {
                temp = CourseNumber;
            }

            return temp;
        }
    }
}
