using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class ComplexNumber11
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber11(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overloading the + operator
        public static ComplexNumber11 operator +(ComplexNumber11 c1, ComplexNumber11 c2)
        {
            return new ComplexNumber11(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Display method to print the complex number
        public void Display()
        {
            Console.WriteLine($"{Real} + {Imaginary}i");
        }
    }
}
