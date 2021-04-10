using System;
using System.Collections;
using System.Collections.Generic;

namespace task_3._2._1
{
    class Program
    {

        static void Main(string[] args)
        {

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 9, 15 };
            DynamicArray<int> mas = new DynamicArray<int>(numbers);

            List<int> numbers1 = new List<int>() { 5, 9, 15 };

            Console.WriteLine("Capacity: " + mas.Capacity + "Length:" + mas.Length);

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    mas.Add(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Capacity: " + mas.Capacity + "Length:" + mas.Length);

        }
    }
}
