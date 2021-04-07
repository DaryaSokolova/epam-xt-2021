﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace task_3._1._1
{
    class Program
    {

        static List<int> rounds(List<int> numbers)
        {
            int count = 1;
            int index = 0;

            while (numbers.Count != 1)
            {
                if (count % 5 == 0)
                {
                    Console.WriteLine($"delete: {numbers[index]}, осталось: {numbers.Count - 1}");
                    numbers.RemoveAt(index);
                    count = 1;
                }
                else
                {
                    int temp = numbers[index];
                    numbers.Remove(temp);
                    numbers.Add(temp);
                    count++;
                }
            }

            Console.WriteLine($"Игра окончена! Остался: {numbers[0]}-й");

            return numbers;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> numbers = new List<int>() { };
            int N = 0; bool fl = true;

            Console.Write("Введите N:");

            try
            {
                N = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                fl = false;
                Console.WriteLine($"Ошибка: {ex.Message}");

            }

            for (int i = 1; i < N + 1; i++)
            {
                numbers.Add(i);
            }

            if (fl == true && N > 1)
            {
                numbers = rounds(numbers);
            }

        }
    }
}
