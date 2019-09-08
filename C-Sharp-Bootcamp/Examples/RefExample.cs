using System;

namespace C_Sharp_Bootcamp.Examples
{

    enum Color { Green, Red, Yellow, Blue };

    class Pen
    {
        internal Color color = Color.Red;

        internal Pen(Color color)
        {
            this.color = color;
        }
    }
    class RefExample
    {
        private static void ChangeColor(Pen pen)
        {
            pen.color = Color.Green;
            Console.WriteLine($"Inside the ChangeColor method the color is {pen.color}");
        }

        private static void CreateNewObjectWithoutRef(Pen pen)
        {
            pen = new Pen(Color.Red);
            Console.WriteLine($"Inside the CreateNewObjectWithoutRef method the color of new pen object is {pen.color}");
        }

        private static void CreateNewObjectWithRef(ref Pen pen)
        {
            pen = new Pen(Color.Yellow);
            Console.WriteLine($"Inside the CreateNewObjectWithRef method the color of new pen object is {pen.color}");
        }

        public static void InternalMain()
        {
            Pen pen = new Pen(Color.Blue);

            Console.WriteLine($"Before ChangeColor method: {pen.color}");
            ChangeColor(pen);
            Console.WriteLine($"After the ChangeColor method: {pen.color}");

            Console.WriteLine();

            Console.WriteLine($"Before CreateNewObjectWithoutRef method: {pen.color}");
            CreateNewObjectWithoutRef(pen);
            Console.WriteLine($"After CreateNewObjectWithoutRef method: {pen.color}");

            Console.WriteLine();

            Console.WriteLine($"Before CreateNewObjectWithRef method: {pen.color}");
            CreateNewObjectWithRef(ref pen);
            Console.WriteLine($"After CreateNewObjectWithRef method: {pen.color}");

            Console.ReadKey();
        }
    }
}
