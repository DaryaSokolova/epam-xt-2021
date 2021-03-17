﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    class Triangle : Figure, IHaveArea
    {
        private int part1 = 0;
        private int part2 = 0;
        private int part3 = 0;

        public int Part1
        {
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    part1 = value;
                }
            }
            get { return part1; }
        }

        public int Part2
        {
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    part1 = value;
                }
            }
            get { return part2; }
        }

        public int Part3
        {
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    part1 = value;
                }
            }
            get { return part3; }
        }

        public Triangle(int part1, int part2, int part3)
        {
            Part1 = part1;
            Part2 = part2;
            Part3 = part3;
        }

        public override double GetPerimeter() => part1 + part2 + part3;
        public virtual double GetArea() => Math.Sqrt(GetPerimeter() / 2 * (GetPerimeter() / 2 - part1) * (GetPerimeter() / 2 - part2) * (GetPerimeter() / 2 - part3));
    }
}
