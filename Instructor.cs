using System;
using System.Collections.Generic;

namespace Student_Exercises
{
    class Instructor : NSSPerson
    {
       
        public string InstructorSpecialty { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();

        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }
    }
}
