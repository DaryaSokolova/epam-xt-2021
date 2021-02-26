using System;

namespace task_1_2
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
                    string text = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";

                    int count = 0; double sum = 0;

                    string []str = text.Split(' ', '.', ',', '!', '?', ':', '-');

                    for (int i=0; i<str.Length; i++)
                    {
                        if (str[i] != "")
                        {
                            sum += str[i].Length;
                            count++;
                        }
                    }

                    Console.WriteLine("Результат: {0}", sum/count);
                    break;

                case 2:


                    break;

                default:
                    Console.WriteLine("Такого номера нет :( ");
                    break;
            }
        }
    }
}
