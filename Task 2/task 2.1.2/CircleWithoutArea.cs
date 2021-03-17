﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    class CircleWithoutArea: RoundShape
    {
        public CircleWithoutArea(int x, int y, int radius) : base(x, y, radius) { }

        public override double GetPerimeter() => 2 * Math.PI * radius;
    }
}
