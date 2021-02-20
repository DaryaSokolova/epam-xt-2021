﻿using System;

namespace task_1_1
{

    enum format
    {
        None =0,
        bold =1,
        italic =2,
        underline =3
    }

    class Program
    {
        static void quicksort(int []a, int l, int r)
        {
            int i = l; int j = r;
            int m = a[(r + l) / 2];

            while (i <= j)
            {
                while (a[i] < m)
                {
                    i++;
                }
                while (a[j] > m)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;

                    i++;
                    j--;
                }
            }

            if (j > l) quicksort(a, l, j);
            if (i < r) quicksort(a, i, r);
        }
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

                case 6:
                    bool exitFromCase6 = true;
                    int[] nums = new int[4] { 0, 0, 0, 0 };

                    Console.WriteLine("Параметры записи : {0}", (format)0);

                    while (exitFromCase6)
                    {
                        Console.WriteLine("Введите :");
                        Console.WriteLine("1: bold ");
                        Console.WriteLine("2: italic ");
                        Console.WriteLine("3: underline ");
                        Console.WriteLine("Иные цифры: выход из программы :) ");

                        string strNums = "";
                        int formatOfText = Convert.ToInt32(Console.ReadLine());

                        if (formatOfText > 0 && formatOfText < 4)
                        {

                            if (nums[formatOfText] == 0)
                            {
                                nums[formatOfText] = 1;
                            }
                            else
                            {
                                nums[formatOfText] = 0;
                            }

                            int countOfFormat = 0;
                            for(int i=1; i<nums.Length; i++)
                            {
                                if(nums[i] == 1)
                                {
                                    strNums += (format)i + " ";
                                    countOfFormat++;
                                }
                            }

                            if(countOfFormat==0)
                            {
                                strNums += (format)0;
                            }

                            Console.WriteLine("Параметры записи : {0}", strNums);
                        }
                        else
                        {
                            exitFromCase6 = false;
                        }
                    }

                    break;

                case 7:

                    int[] arr = new int[10];
                    int min = Int32.MaxValue;
                    int max = Int32.MinValue;
                    Random rnd = new Random();

                    for(int i=0; i<arr.Length; i++)
                    {
                        int value = rnd.Next(-100, 100);
                        arr[i] = value;

                        if (arr[i] > max)
                        {
                            max = arr[i];
                        }

                        if (arr[i] < min)
                        {
                            min = arr[i];
                        }

                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();

                    Console.WriteLine("min : {0}, max : {1}", min, max);
                    quicksort(arr, 0, arr.Length-1);

                    Console.WriteLine("Отсортированный массив :");
                    foreach (int num in arr)
                    {
                        Console.Write(num + " " );
                    }

                    break;

                default:
                    Console.WriteLine("Такого номера нет :( ");
                    break;
            }
        }
    }
}
