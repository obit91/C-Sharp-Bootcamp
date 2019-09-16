using System;
using System.Collections.Generic;
using System.Text;

//inner project namespaces
using C_Sharp_Bootcamp.Demos.IO.Read;
using C_Sharp_Bootcamp.Demos.IO.Write;

namespace C_Sharp_Bootcamp
{
    class MainRunner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing read:");
            FileAccessReadDemo.InnerMain();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Testing write:");
            FileAccessWriteDemo.InnerMain();
        }
    }
}
