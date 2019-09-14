using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Bootcamp.Demos.DynamicPoly.Abstract
{
    abstract class Shape
    {
        public abstract int Area();
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int Area()
        {
            Console.WriteLine("Rectangle class calculated.");
            return (width * length);
        }
    }
    class AbstractTester
    {
        internal static void InnerMain()
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.Area();
            Console.WriteLine("Area: {0}", a);
        }
    }
}

namespace C_Sharp_Bootcamp.Demos.DynamicPoly.Virtual
{
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int Area()
        {
            Console.WriteLine("Shape class area calculated.");
            return 0;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int Area()
        {
            Console.WriteLine("Rectangle class area calculated.");
            return (width * height);
        }
    }
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int Area()
        {
            Console.WriteLine("Triangle class area caculated.");
            return (width * height / 2);
        }
    }
    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.Area();
            Console.WriteLine("Area: {0}", a);
        }
    }
    class VirtualTester
    {
        internal static void InnerMain()
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);
            Shape s = new Shape(2, 3);

            c.CallArea(r);
            c.CallArea(t);
            c.CallArea(s);
        }
    }
}
