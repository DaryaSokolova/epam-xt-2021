using System;

namespace task_2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Circle cl = new Circle(3,4,5);

            Console.WriteLine(cl.GetArea());

            Ring rg = new Ring(3, 4, 3, 4);

            Console.WriteLine(rg.GetArea());
        }
    }
}
