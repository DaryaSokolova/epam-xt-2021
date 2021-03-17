using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    class Rectangle : Figure, IHaveArea
    {

        private int height = 0;
        private int width = 0;

        public int Height
        {
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    height = value;
                }
            }
            get { return height; }
        }

        public int Width
        {
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    width = value;
                }
            }
            get { return width; }
        }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override double GetPerimeter() => 2 * (width * height);

        public double GetArea() => width * height;
    }
}
