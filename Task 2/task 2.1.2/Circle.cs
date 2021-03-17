using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    class Circle : RoundShape, IHaveArea
    {
        public Circle(int x, int y, int radius) : base(x, y, radius) { }

        public override double GetPerimeter() => 2 * Math.PI * radius;

        public double GetArea() => Math.PI * radius * radius;
    }
}
