//Copyright(c) Christopher Aram Swayne

using System;
namespace CourseSchedule
{
    public interface ISchedule
    {
        int PerformFitness();
        int CompareFitness(Schedule other);
    }
}
