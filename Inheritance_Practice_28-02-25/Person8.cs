using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance_Practice_28_02_25
{
    public class Person8
    {
        public string Name { get; set; }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Person Name: {Name}");
        }
    }

    public class Student : Person8
    {
        public int StudentID { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"Student Name: {Name}, ID: {StudentID}");
        }
    }
}
