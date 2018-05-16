using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Lab1_OOP_C_Sharp{
    public class UProgram{

        public string Programname { get; set; }
        public LinkedList<Degree> Degrees = new LinkedList<Degree>();
        public static int programs = 0; 

         

        public UProgram(string programname){
            this.Programname = programname;
            programs++;
        }

        public UProgram(){
            programs++;
        }

        public static int ProgramNames(){
            return programs;
        }

      
    }
}
