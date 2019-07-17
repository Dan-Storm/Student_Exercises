using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercises
            Exercise ChickenMonkey = new Exercise()
            {
                ExerciseName = "Chicken Monkey",
                ExerciseLanguage = "JavaScript"
            };
            Exercise MonkeyChicken = new Exercise()
            {
                ExerciseName = "Monkey Chicken",
                ExerciseLanguage = "JavaScript"
            };
            Exercise CsYes = new Exercise()
            {
                ExerciseName = "C S Yes",
                ExerciseLanguage = "CSS"
            };
            Exercise DeepThoughtsBlog = new Exercise()
            {
                ExerciseName = "Deep Thoughts Blog",
                ExerciseLanguage = "HTML"
            };

            // Cohorts
            Cohort day32 = new Cohort()
            {
                CohortNumber = 32,
                CohortName = "Day Cohort 32"
            };
            Cohort e6 = new Cohort()
            {
                CohortNumber = 6,
                CohortName = "Evening Cohort 6"
            };
            Cohort day33 = new Cohort()
            {
                CohortNumber = 33,
                CohortName = "Day Cohort 33"
            };
            Cohort day34 = new Cohort()
            {
                CohortNumber = 34,
                CohortName = "Day Cohort 34"
            };
            // Students
            Student JoeyDriscoll = new Student()
            {
                FirstName = "Joey",
                LastName = "Driscoll",
                SlackHandle = "TheJoe-ster",
                Cohort = 32
            };
            Student DeepPatel = new Student()
            {
                FirstName = "Deep",
                LastName = "Patel",
                SlackHandle = "deep-thinker",
                Cohort = 32
            };
            Student LoganPalmer = new Student()
            {
                FirstName = "Logan",
                LastName = "Palmer",
                SlackHandle = "Logie-Palmie",
                Cohort = 32
            };
            Student DekHaji = new Student()
            {
                FirstName = "Dek",
                LastName = "Haji",
                SlackHandle = "Tech-Dek",
                Cohort = 32
            };
            // Instructors
            Instructor AdamSheaffer = new Instructor()
            {
                FirstName = "Adam",
                LastName = "Sheaffer",
                SlackHandle = "mad-hatter",
                Cohort = 32,
                InstructorSpecialty = "Wearing hats",
            };

            Instructor BryanNielsen = new Instructor()
            {
                FirstName = "Bryan",
                LastName = "Nielsen",
                SlackHandle = "bry-guy",
                Cohort = 32,
                InstructorSpecialty = "Giving high 5s",
            };
            Instructor BrendaLong = new Instructor()
            {
                FirstName = "Brenda",
                LastName = "Long",
                SlackHandle = "UbLong",
                Cohort = 32,
                InstructorSpecialty = "Star Wars Jokes",
            };
            // Adding Instructors to Cohorts
            day32.AddInstructor(BrendaLong);
            day32.AddInstructor(AdamSheaffer);
            day32.AddInstructor(BryanNielsen);
            // Adding Students to Cohorts
            day32.AddStudent(DeepPatel);
            day32.AddStudent(JoeyDriscoll);
            day32.AddStudent(LoganPalmer);
            // Assignments
            BrendaLong.AssignExercise(LoganPalmer, ChickenMonkey);
            BrendaLong.AssignExercise(LoganPalmer, MonkeyChicken);
            BrendaLong.AssignExercise(LoganPalmer, CsYes);
            BrendaLong.AssignExercise(DeepPatel, ChickenMonkey);
            BrendaLong.AssignExercise(DeepPatel, MonkeyChicken);
            BrendaLong.AssignExercise(JoeyDriscoll, ChickenMonkey);
            BrendaLong.AssignExercise(JoeyDriscoll, MonkeyChicken);

            BryanNielsen.AssignExercise(LoganPalmer, ChickenMonkey);
            BryanNielsen.AssignExercise(LoganPalmer, MonkeyChicken);
            BryanNielsen.AssignExercise(DeepPatel, ChickenMonkey);
            BryanNielsen.AssignExercise(DeepPatel, MonkeyChicken);
            BryanNielsen.AssignExercise(JoeyDriscoll, ChickenMonkey);
            BryanNielsen.AssignExercise(JoeyDriscoll, MonkeyChicken);

            AdamSheaffer.AssignExercise(LoganPalmer, ChickenMonkey);
            AdamSheaffer.AssignExercise(LoganPalmer, MonkeyChicken);
            AdamSheaffer.AssignExercise(DeepPatel, ChickenMonkey);
            AdamSheaffer.AssignExercise(DeepPatel, MonkeyChicken);
            AdamSheaffer.AssignExercise(JoeyDriscoll, ChickenMonkey);
            AdamSheaffer.AssignExercise(JoeyDriscoll, MonkeyChicken);

            List<Student> students = new List<Student>();
            List<Exercise> exercises = new List<Exercise>();
            List<Instructor> instructors = new List<Instructor>();
            List<Cohort> cohorts = new List<Cohort>();
            // Add Exercise to exercises List
            exercises.Add(MonkeyChicken);
            exercises.Add(ChickenMonkey);
            exercises.Add(CsYes);
            exercises.Add(DeepThoughtsBlog);
            // Add Student to studetns List
            students.Add(JoeyDriscoll);
            students.Add(DeepPatel);
            students.Add(LoganPalmer);
            students.Add(DekHaji);
            // Add Cohort to cohorts List
            cohorts.Add(day32);
            cohorts.Add(day33);
            cohorts.Add(day34);
            cohorts.Add(e6);
            // Add Instructor to instructors List
            instructors.Add(AdamSheaffer);
            instructors.Add(BryanNielsen);
            instructors.Add(BrendaLong);
            // Iterate over students List and print their name and exercises assigned to them
            foreach (Student student in students)
            {
                Console.WriteLine($"Student: {student.FirstName}");
                Console.WriteLine("-----------------------------");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"Exercise: {exercise.ExerciseName}");
                }
            }
            // List exercises for the JavaScript language by using the Where() LINQ method.
            var JscriptExercises = from exercise in exercises
                                   where exercise.ExerciseLanguage == "JavaScript"
                                   select exercise;

            foreach (var exercise in JscriptExercises)
            {
                Console.WriteLine(exercise.ExerciseName);
            }
            System.Console.WriteLine("---------------------");

            // List students in a particular cohort by using the Where() LINQ method.
            var CohortStudents = from student in students
                                 where student.Cohort == 32
                                 orderby student.LastName
                                 select student;

            Console.WriteLine("Cohort 32 Students");

            foreach (var student in CohortStudents)
            {
                Console.WriteLine(student.FirstName);
            }
            System.Console.WriteLine("---------------------");
            // List instructors in a particular cohort by using the Where() LINQ method.
            var CohortInstructors = from instructor in instructors
                                    where instructor.Cohort == 32
                                    orderby instructor.LastName
                                    select instructor;

            Console.WriteLine("Cohort 32 Instructors");

            foreach (var instructor in CohortInstructors)
            {
                Console.WriteLine(instructor.FirstName);
            }
            System.Console.WriteLine("---------------------");
            // Display any students that aren't working on any exercises 
            var NeedExercises = from student in students
                                    where student.Exercises.Count == 0
                                    orderby student.LastName
                                    select student;

            foreach (var student in NeedExercises)
            {
                Console.WriteLine($"{student.FirstName} needs new exercises assigned");
            }
            System.Console.WriteLine("---------------------");

            //Which student is working on the most exercises?
            var MostExercises = students.OrderByDescending(student => student.Exercises.Count()).Take(1);
                                   
            foreach (var student in MostExercises)
            {
                Console.WriteLine($"{student.FirstName} needs help finishing his exercises");
            }
            System.Console.WriteLine("---------------------");

            foreach (var cohort in cohorts)
            {
                Console.WriteLine($"{cohort.CohortName} has {cohort.Students.Count()}students");
            }
        }
    }
}
