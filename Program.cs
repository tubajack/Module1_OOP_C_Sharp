using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Lab1_OOP_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a new UProgram
            UProgram UProgram1 = new UProgram("Information Technology");
           
            //Instantiate a Degree program
            Degree DegreeProgram1 = new Degree("Bachelor's");

            //Instantiate a Course Object
            Course Course1 = new Course("Programming with C#");

            //Instantiate three students
            Student student1 = new Student("Johnny", "Lawrence");
            Student student2 = new Student("Daniel", "Larusso");
            Student student3 = new Student("Mike", "Barnes");

            //Instantiate teacher
            Teacher teacher1 = new Teacher("John", "Kreese");

            //Add students and teachers to the course
            Course1.students.AddFirst(new Student("Johnny", "Lawrence"));
            Course1.students.AddFirst(student2);
            Course1.students.AddFirst(student3);
            Course1.teachers.AddLast(teacher1);
          
            
            //Add the course to the degree plan
            DegreeProgram1.courses.AddLast(Course1);

            //Add the degree to the program
            UProgram1.Degrees.AddLast(DegreeProgram1);

            Console.WriteLine($"Program: {UProgram1.Programname}");
            foreach(Degree deg in UProgram1.Degrees)
            {
                Console.WriteLine($"Degree: {deg.DegreeType}");
                foreach(Course cu in deg.courses)
                {
                    Console.WriteLine($"Course: {cu.Coursename}");
                    foreach(Student s in cu.students)
                    {
                        Console.WriteLine($"Student: {s.Firstname}, {s.Lastname}");
                    }
                    foreach(Teacher t in cu.teachers)
                    {
                        Console.WriteLine($"Teacher: {t.Teacherfirst}, {t.Teacherlast}");
                    }
                }
            }

        }
    }

}
