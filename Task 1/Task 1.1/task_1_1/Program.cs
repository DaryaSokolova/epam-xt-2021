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

                case 2:
                    Console.Write("Введите N :");
                    int N = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < i + 1; j++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }

                    break;

                case 3:
                    Console.Write("Введите N :");
                    N = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 1; j < N - i; j++)
                        {
                            Console.Write(' ');
                        }

                        for (int j = N - 2 * i; j <= N; j++)
                        {
                            Console.Write('*');

                        }

                        Console.WriteLine();
                    }

                    break;

                case 4:
                    Console.Write("Введите N :");
                    N = Convert.ToInt32(Console.ReadLine());

                    for (int indexTriangle = 1; indexTriangle <= N; indexTriangle++)
                    {
                        for (int i = 0; i < indexTriangle; i++)
                        {
                            for (int j = 1; j < N - i; j++)
                            {
                                Console.Write(' ');
                            }

                            for (int j = indexTriangle - 2 * i; j <= indexTriangle; j++)
                            {
                                Console.Write('*');

                            }

                            Console.WriteLine();
                        }
                    }

                    break;

                case 5:

                    int sum = 0;

                    for(int i=0; i<1000; i++)
                    {
                        if (i % 5 == 0 || i % 3 == 0)
                        {
                            sum += i;
                        }
                    }
                    Console.WriteLine("Результат: {0}", sum);

                    break;

                default:
                    Console.WriteLine("Такого номера нет :( ");
                    break;
            }
        }
    }
}
