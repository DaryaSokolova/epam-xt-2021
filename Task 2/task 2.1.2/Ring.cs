using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    class Ring : RoundShape, IHaveArea
    {
        private int innerRadius = 0;

        public int InnerRadius
        {
            private set
            {
                if (value < 0 || value >= radius)
                {
                    throw new Exception("Отрицательный InnerRadius!");
                }
                else
                {
                    if (value >= radius)
                    {
                        throw new Exception("InnerRadius>= Radius!");
                    }
                    else
                    {
                        innerRadius = value;

                    }
                }
            }
            get { return innerRadius; }
        }

        public Ring(int x, int y, int radius, int innerRadius) : base(x, y, radius)
        {
            InnerRadius = innerRadius;
        }

        public Ring() { }

        public double GetArea() => Math.PI * (radius * radius - innerRadius * innerRadius);

        public override double GetPerimeter() => 2 * Math.PI * (radius + innerRadius);

        public override void Enter()
        {
            Console.WriteLine("x=");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y=");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("radius=");
            Radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("innerRadius=");
            InnerRadius = Convert.ToInt32(Console.ReadLine());
        }

        public override string GetInfo()
        {
            return ($"КРУГ: Координаты: {x},{y} Радиус: {radius} Внутренний радиус: {innerRadius} Площадь: {GetArea()} Длина: {GetPerimeter()}");
        }
    }
}
