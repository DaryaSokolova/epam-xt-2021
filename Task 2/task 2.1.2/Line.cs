using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    class Line : Figure
    {
        private int x1;
        private int y1;

        private int x2;
        private int y2;

        public int X1 
        {
            get
            {
                return x1;
            }

            private set
            {
                x1 = value;
            }
        }

        public int Y1
        {
            get
            {
                return y1;
            }

            private set
            {
                y1 = value;
            }
        }

        public int X2
        {
            get
            {
                return x2;
            }

            private set
            {
                x2 = value;
            }
        }
        public int Y2
        {
            get
            {
                return y2;
            }

            private set
            {
                y2 = value;
            }
        }

        public Line(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public Line() { }
        public override double GetPerimeter() => Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

        public override void Enter()
        {
            Console.WriteLine("x1=");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1=");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2=");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2=");
            y2 = Convert.ToInt32(Console.ReadLine());
        }
        public override string GetInfo()
        {
            return ($"ЛИНИЯ: Координаты точек линии: ({x1},{y1}) и ({x2},{y2}), а длина равна: {GetPerimeter()}");
        }
    }
}
