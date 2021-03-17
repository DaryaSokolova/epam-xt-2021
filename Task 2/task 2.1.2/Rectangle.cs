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
                    throw new Exception("Отрицательный Height!");
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
        public Rectangle() { }

        public override double GetPerimeter() => 2 * (width * height);
        public override double GetArea() => width * height;

        public override string GetInfo()
        {
            return ($"ПРЯМОУГОЛЬНИК: Длины: {height} и {width} Периметр: {GetPerimeter()} Площадь: {GetArea()}");
        }

        public override void Enter()
        {
            Console.WriteLine("height=");
            Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("width=");
            Width = Convert.ToInt32(Console.ReadLine());
        }
    }
}
