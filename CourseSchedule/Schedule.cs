//Copyright(c) Christopher Aram Swayne

using System;
using System.IO;
using System.Collections.Generic;

namespace CourseSchedule
{
    public class Schedule : ISchedule
    {
        public Room[] Rooms;
        public Course[] Courses;
        public Instructor[] Instructors;


        public Schedule()
        {
        }

        /// <summary>
        /// Generates the list of instructors from the text file, and adds them to the
        /// Instructor[], Instructors.
        /// </summary>
        /// <param name="fileName"></param>
        public void GenerateInstructors(string fileName)
        {
            Queue<string> instructorQueue = new Queue<string>();
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    //Reads the lines from the file and adds each line to the queue.
                    while ((line = reader.ReadLine()) != null)
                    {
                        instructorQueue.Enqueue(line);
                    }
                }
            }
            catch (Exception e)//Throws an error if there is an issue reading the file.
            {
                Console.WriteLine("Error in reading: " + fileName);
                Console.WriteLine(e.Message);
            }
            //Dequeue the items from the queue and place them in the array of instructors.
            int counter = 0;
            while (instructorQueue.Peek() != null)
            {
                Instructors[counter] = new Instructor(instructorQueue.Dequeue());

            }
        }

        /// <summary>
        /// Generates the list of courses from the text file, and adds them to
        /// the Course[], Courses.
        /// </summary>
        /// <param name="fileName"></param>
        public void GenerateCourses(string fileName)
        {
            Queue<string> courseQueue = new Queue<string>();
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    //Reads the lines from the file and adds each line to the queue.
                    while ((line = reader.ReadLine()) != null)
                    {
                        courseQueue.Enqueue(line);
                    }

                }
            }
            catch (Exception e)
            //Throws an error if there is an issue reading the file.
            {
                Console.WriteLine("Error in reading: " + fileName);
                Console.WriteLine(e.Message);
            }

            //Dequeue the items from the queue and place them in the array of courses.
            int counter = 0;
            while (courseQueue.Peek() != null )
            {
                Courses[counter] = new Course();

                courseQueue.Dequeue();
            }
            

        }

        public int PerformFitness()
        {
            throw new NotImplementedException();
        }

        public int CompareFitness(Schedule other)
        {
            throw new NotImplementedException();
        }
    }
}
