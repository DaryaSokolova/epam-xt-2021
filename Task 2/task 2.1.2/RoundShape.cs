using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    abstract class RoundShape : Figure
    {
        protected int radius;
        protected int x;
        protected int y;

        public int Radius
        {
            protected set
            {
                if (value < 0)
                {
                    throw new Exception("Отрицательный Radius!");
                }
                else
                {
                    radius = value;
                }
            }
            get { return radius; }
        }

        public int X
        {
            get
            {
                return x;
            }

            private set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            private set
            {
                y = value;
            }
        }

        public RoundShape(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public RoundShape() { }

        public override void Enter()
        {
            Console.Write("x=");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("radius=");
            Radius = Convert.ToInt32(Console.ReadLine());
        }

    }
}