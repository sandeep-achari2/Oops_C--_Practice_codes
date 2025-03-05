using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class Vechile5
    {
        public virtual void Start()
        {
            Console.WriteLine("Vechile Started");
        }
    }
    class Car : Vechile5
    {
        public override void Start()
        {
            Console.WriteLine("Car is started.. & Ready To goo..");
        }
    } 
    class Bike : Vechile5
    {
        public override void Start()
        {
            Console.WriteLine("Bike is started And Ready to racee... ");
        }
    }
}
