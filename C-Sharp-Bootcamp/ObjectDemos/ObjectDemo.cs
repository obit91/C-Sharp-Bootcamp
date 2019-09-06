using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Bootcamp.ObjectDemos
{
    class ObjectDemo
    {
        private readonly int a = 5;

        static internal void StaticInnerMain()
        {
            ObjectDemo demo = new ObjectDemo();
            demo.PrintA();
        }

        internal void InnerMain()
        {
            ObjectDemo demo = new ObjectDemo();
            demo.PrintA();
        }

        private void PrintA()
        {
            Console.WriteLine($"The value of a is: {a}");
        }
    }
}
