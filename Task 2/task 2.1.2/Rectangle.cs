using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    class Rectangle : Quadrate, IHaveArea
    {
        private int height = 0;

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

        public Rectangle(int height, int width): base(width)
        {
            Height = height;
        }

        public override double GetPerimeter() => 2 * (width * height);
        public override double GetArea() => width * height;
    }
}
