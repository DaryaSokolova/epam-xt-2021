using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    class Ring : RoundShape
    {
        private int innerRadius = 0;

        public int InnerRadius
        {
            private set
            {
                if (value < 0 || value >= radius)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    innerRadius = value;
                }
            }
            get { return innerRadius; }
        }

        public Ring(int x, int y, int radius, int innerRadius) : base(x, y, radius)
        {
            InnerRadius = innerRadius;
        }

        public override double GetArea()=> Math.PI * (radius * radius - innerRadius * innerRadius);

        public override double GetPerimeter() => 2 * Math.PI * (radius + innerRadius);
    }
}
