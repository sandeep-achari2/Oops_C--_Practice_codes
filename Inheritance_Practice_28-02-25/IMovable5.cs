using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_28_02_25
{
    public interface IMovable5
    {
        void Move();
    }
    public class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine is starting...");
        }
    }
    public class Robot : Machine, IMovable5
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving...");
        }
    }
}
