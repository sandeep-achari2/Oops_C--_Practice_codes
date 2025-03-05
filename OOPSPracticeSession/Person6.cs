using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class Person6
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    class Student : Person6
    {
        public string StudentID { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}, ID: {StudentID}");
        }
    }
    class Teacher : Person6
    {
        public string Subject { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine($"Teacher Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
}
