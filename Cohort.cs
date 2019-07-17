using System;
using System.Collections.Generic;

namespace Student_Exercises
{
    class Cohort
    {
        public int CohortNumber { get; set; }
        public string CohortName { get; set; }
        public List<Student> Students = new List<Student>();
        public List<Instructor> Instructors = new List<Instructor>();

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddInstructor(Instructor instructor)
        {
            Instructors.Add(instructor);
        }
    }
}
