using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Lab1_OOP_C_Sharp{
    public class Course{

        public string Coursename { get; set; }
        public LinkedList<Student> students = new LinkedList<Student>();
        public LinkedList<Teacher> teachers = new LinkedList<Teacher>();

        public static int courses = 0;


        public Course(string coursename){
            this.Coursename = coursename;
            courses++;
        }

        public Course(){
            courses++;
        }

        public static int CourseCount()
        {
            return courses;
        }
    }
}
