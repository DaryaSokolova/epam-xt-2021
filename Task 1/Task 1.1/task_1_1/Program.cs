using System;

namespace task_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Console.WriteLine("Введите a :");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите b :");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (a < 0 || b < 0)
                    {
                        Console.WriteLine("Введены некорректные значения");
                    }
                    else
                    {
                        Console.WriteLine("Результат: {0}", a * b);
                    }

                    break;

                default:
                    Console.WriteLine("Такого номера нет :( ");
                    break;
            }
        }
    }
}
