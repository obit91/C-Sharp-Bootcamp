using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Bootcamp.Demos.Polymorphism.StaticPoly.OverloadOps
{
    internal class Complex
    {
        float real;
        float imaginary;

        public Complex(float real, float imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public float Real
        {
            get
            {
                return (real);
            }
            set
            {
                real = value;
            }
        }

        public float Imaginary
        {
            get
            {
                return (imaginary);
            }
            set
            {
                imaginary = value;
            }
        }

        public static Complex operator+ (Complex c1, Complex c2)
        {
            return (new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary));
        }

        public override string ToString()
        {
            return (String.Format("({0}, {1}i)", real, imaginary));
        }
    }

    class OverloadTester
    {
        internal static void InnerMain()
        {
            Complex c1 = new Complex(2, 2);
            Complex c2 = new Complex(1, -1);
            Complex c3 = c1 + c2;
            Console.WriteLine($"{c1} + {c2} = {c3}");

        }
    }

}
