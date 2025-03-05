using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_28_02_25
{
    public abstract class Animal4
    {
        public string Name { get; set; }
        public abstract void MakeSound();
    }
    public class Dog : Animal4
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Bow! Bow! ");
        }
    }
    public class Cat : Animal4
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says: Meow! Meow!");
        }
    }

}