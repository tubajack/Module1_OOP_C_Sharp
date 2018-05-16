using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Lab1_OOP_C_Sharp{
    public class Student{

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        private static int totalstudents = 0; 

        public Student(string firstname, string lastname){
            this.Firstname = firstname;
            this.Lastname = lastname;
            totalstudents++;
        }

        public Student(){
            totalstudents++;
        }

        public static int CountStudents(){
            return totalstudents;
        }

    }
}
