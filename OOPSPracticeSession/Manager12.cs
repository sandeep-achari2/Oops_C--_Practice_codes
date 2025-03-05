using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class Manager12
    {
        public string Name { get; set; }

        public Manager12(string name)
        {
            Name = name;
        }
    }
    class Department
    {
        public string DeptName { get; set; }
        public Manager12 Manager { get; set; } // Reference type property

        public Department(string deptName, string managerName)
        {
            DeptName = deptName;
            Manager = new Manager12(managerName);
        }

        // Shallow Copy
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        // Deep Copy
        public Department DeepCopy()
        {
            return new Department(this.DeptName, this.Manager.Name);
        }

        public void Display()
        {
            Console.WriteLine($"Department: {DeptName}, Manager: {Manager.Name}");
        }
    }
}
