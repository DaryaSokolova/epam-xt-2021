using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    class Quadrate : Figure, IHaveArea
    {
        protected int width = 0;

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

        public Quadrate(int width)
        {
            Width = width;
        }

        public override double GetPerimeter() => 4 * width;
        public virtual double GetArea() => width * width;
    }
}
