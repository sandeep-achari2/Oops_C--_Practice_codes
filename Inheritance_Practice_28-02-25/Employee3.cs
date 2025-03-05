using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_28_02_25
{
    public class Employee3
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee3(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary:$ {Salary:C}");
        }
    }
    public class Manager : Employee3
    {
        public double Bonus { get; set; }
        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
        public void DisplayManagerInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus:C}");
        }
    }
}
