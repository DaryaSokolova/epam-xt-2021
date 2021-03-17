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
            protected set
            {
                if (value < 0)
                {
                    throw new Exception("Отрицательный Width!");
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

        public Quadrate() { }

        public override double GetPerimeter() => 4 * width;
        public virtual double GetArea() => width * width;

        public override void Enter()
        {
            Console.WriteLine("width=");
            Width = Convert.ToInt32(Console.ReadLine());
        }

        public override string GetInfo()
        {
            return ($"КВАДРАТ: Длины: {width} Периметр: {GetPerimeter()} Площадь: {GetArea()}");
        }
    }
}
