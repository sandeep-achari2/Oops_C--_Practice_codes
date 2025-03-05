using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_28_02_25
{
    public interface IFlyable7
    {
        void Fly();
    }
    public interface ISwimmable
    {
        void Swim();
    }
    public class Duck : IFlyable7, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("The duck is flying.");
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming.");
        }
    }
}
