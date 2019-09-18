# CourseSchedule
 Artificial Intelligence Project 2

This assignment will be over Genetic Algorithms. The Readme will contain the project details.

Your assignment is to create a course schedule, where:
* All Courses must be taught.
* One course per room per time slot.
* Each instructor can teach any of the courses
    * However, there is an upper limit on how many courses each instructor can teach.
* Courses in the same semester are preferred to be close in time slots and in the same building.

You are given a list of _12 courses_. You also have a list of several faculty members, and the courses they can teach.
You also have a list of available rooms and time slots. Your task is to use a genetic algorithm to devise a suitable teaching schedule. 

_Fitness Function_
This is where the genetic algorithm will compare *each schedule* amongst these requirements, and use to (hopefully) improve.
* Rewards:
    + 3- Course is taught by applicable instructors
    + 5- Course is the only one to be scheduled in that room at that time.
    + 5- Room is large enough to hold the class
        + 2- Room's capacity is no more than 2x enrollment
    + 5- Instructor is not teaching another course at the same time
* "Punishments"
    - 5- (minus 5 points per course over 4) If the teacher is teaching more than 4 courses.
    - 5%- Rao/Mitchell are graduate faulty, and if they are teaching more courses then Hare or Bingham, then -5% the total fitness score.


