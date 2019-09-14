using System;
using System.Collections.Generic;
using System.Text;

//inner project namespaces
using C_Sharp_Bootcamp.Demos.DynamicPoly.Abstract;
using C_Sharp_Bootcamp.Demos.DynamicPoly.Virtual;

namespace C_Sharp_Bootcamp
{
    class MainRunner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract tester.");
            AbstractTester.InnerMain();
            Console.WriteLine();
            Console.WriteLine("Virtual tester.");
            VirtualTester.InnerMain();

        }

    }
}
