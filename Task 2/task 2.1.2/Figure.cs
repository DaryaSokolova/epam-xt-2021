using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    abstract class Figure
    {
        public Figure() { }
        public abstract double GetPerimeter();

        public abstract void Enter();

        public abstract string GetInfo();
    }
}
