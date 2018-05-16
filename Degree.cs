using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Lab1_OOP_C_Sharp{
    public class Degree{

        public string DegreeType { get; set; }
        public LinkedList<Course> courses = new LinkedList<Course>();
        public static int degrees = 0; 

        public Degree(string degreeType){
            this.DegreeType = degreeType;
            degrees++;
        }

        public Degree(){
            degrees++;
        }

        public static int Degreecount()
        {
            return degrees;
        }
    }
}
