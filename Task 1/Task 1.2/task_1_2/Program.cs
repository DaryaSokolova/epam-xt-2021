using System;

namespace task_1_2
{
    class Program
    {
        static void Task1()
        {
            string text = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";

            int count = 0; double sum = 0;

            string[] word = text.Split(' ', '.', ',', '!', '?', ':', '-');

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != "")
                {
                    sum += word[i].Length;
                    count++;
                }
            }

            Console.WriteLine("Результат: {0}", sum / count);
        }

        static void Task2()
        {
            string first = "написать программу, которая";
            string second = "описание";
            string answer = "";

            foreach (char ch in first)
            {

                if (!second.Contains(ch))
                {
                    answer += ch;
                }
                else
                {
                    answer += ch;
                    answer += ch;
                }
            }

            Console.WriteLine("Результат: {0}", answer);
        }

        static void Task3()
        {
            string text = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны";

            int count = 0;

            string[] word = text.Split(' ', '.', ',', '!', '?', ':', '-');

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != "")
                {

                    string firstSymbol = word[i];
                    if (char.IsLower(firstSymbol[0]))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Результат: {0}", count);
        }

        static void Task4()
        {
            string text = "я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать программу!";

            string[] sentence = text.Split('.', '!', '?');

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != "")
                {

                    sentence[i] = sentence[i].Trim();
                    sentence[i] += text.Substring(text.LastIndexOf(sentence[i]) + sentence[i].Length, 1);

                    string temp = sentence[i];
                    sentence[i] = char.ToUpper(temp[0]) + temp.Substring(1);
                }
            }

            text = string.Join(" ", sentence);

            Console.WriteLine("Результат: {0}", text);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Task1();
                    break;

                case 2:
                    Task2();
                    break;

                case 3:
                    Task3();
                    break;

                case 4:
                    Task4();
                    break;

                default:
                    Console.WriteLine("Такого номера нет :( ");
                    break;
            }
        }
    }
}
