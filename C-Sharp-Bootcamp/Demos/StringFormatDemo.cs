using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Bootcamp.Demos
{
    class StringFormatDemo
    {
        internal static void InnerMain()
        {
            //methods returning string { "Hello", "From", "Tutorials", "Point" };
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2019, 9, 14, 21, 30, 0);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }
    }
}
