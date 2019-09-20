using System;
namespace CourseSchedule
{
    public class Room
    {

        public string Building { get; private set; }
        public int Capacity { get; private set; }
        public int Number { get; private set; }

        /// <summary>
        /// Constructor builds object assigning the parameters to their respective
        /// variable.
        /// </summary>
        /// <param name="building"></param>
        /// <param name="capacity"></param>
        /// <param name="number"></param>
        public Room(string building, int capacity, int number)
        {
            Building = building;
            Capacity = capacity;
            Number = number;
        }

        public Room()
        {
            Building = "";
            Capacity = 0;
            Number = 0;
        }
    }
}
