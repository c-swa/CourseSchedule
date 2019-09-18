﻿using System;
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
        public int CourseSize { get; private set; }
        public bool IsSectioned { get; private set; }
        public int SectionNumber { get; private set; }

        /// <summary>
        /// Initialize a course with empty and default values.
        /// </summary>
        public Course()
        {
            CourseNumber = "";
            CourseSize = 0;
            IsSectioned = false;
        }


        /// <summary>
        /// Creates a course where the courses are to be initialized with non-default
        /// values.
        /// </summary>
        /// <param name="courseNumber"></param>
        /// <param name="courseSize"></param>
        /// <param name="isSectioned"></param>
        public Course(string courseNumber, int courseSize, bool isSectioned)
        {
            CourseNumber = courseNumber;
            CourseSize = courseSize;
            IsSectioned = isSectioned;

        }
    }
}