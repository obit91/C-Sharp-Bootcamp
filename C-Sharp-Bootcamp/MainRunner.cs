using System;
using System.Collections.Generic;
using System.Text;

//inner project namespaces
using C_Sharp_Bootcamp.HelloWorlds;
using C_Sharp_Bootcamp.Demos;
using C_Sharp_Bootcamp.Examples;

namespace C_Sharp_Bootcamp
{
    class MainRunner
    {
        static void Main(string[] args)
        {
            ObjectDemo demo = new ObjectDemo();
            demo.InnerMain();
        }

    }
}
