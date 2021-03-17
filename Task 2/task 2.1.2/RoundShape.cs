using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    abstract class RoundShape : Figure
    {
        protected int radius = 0;
        protected int x;
        protected int y;

        public int Radius
        {
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    radius = value;
                }
            }
            get { return radius; }
        }

        public int X{ get; private set; }

        public int Y { get; private set; }

        public RoundShape(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

    }
}
