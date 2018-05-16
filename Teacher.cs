using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Lab1_OOP_C_Sharp{
    public class Teacher{

        public string Teacherfirst { get; set; }
        public string Teacherlast { get; set; }
        public static int teachers = 0; 

        public Teacher(string Teacherfirst, string Teacherlast){
            this.Teacherfirst = Teacherfirst;
            this.Teacherlast = Teacherlast;
            teachers++;

        }

        public Teacher(){
            teachers++;
        }

        public static int CountTeachers()
        {
            return teachers;
        }

        public static implicit operator LinkedList<object>(Teacher v)
        {
            throw new NotImplementedException();
        }
    }
}
