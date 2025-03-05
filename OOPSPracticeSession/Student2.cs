using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class Student2
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set { name = string.IsNullOrEmpty(value) ? "Unknown" : value; }
        }

        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value < 0 ? 0 : value; }
        }

        public Student2(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }
    }
}
