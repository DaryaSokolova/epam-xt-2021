using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace task_3._1._2
{
    class Program
    {

        static void Analitics(string[] word, Dictionary<string, int> words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = word[i].ToLower();

                if (!words.ContainsKey(word[i]))
                {
                    if (word[i] != "")
                    {
                        words.Add(word[i], 1);

                    }
                }
                else
                {
                    words[word[i]]++;
                }
            }
        }

        static void SwitchAction(int N, Dictionary<string, int> words)
        {
            switch (N)
            {
                case 1:
                    var selectedWords = from w in words
                                        where w.Value > 3
                                        select w;

                    if (selectedWords.Count() != 0)
                    {

                        Console.WriteLine("Слова, повторившиеся более 3 раз:");

                        foreach (var u in selectedWords)
                        {
                            Console.WriteLine(u.Key + "-" + u.Value);
                        }

                        Console.WriteLine("Ваша речь однообразна :((");
                    }
                    else
                    {
                        Console.WriteLine("Таких слов не найдено, у вас богатый словарный запас!");
                    }

                    Console.WriteLine("");

                    break;

                case 2:
                    var sortedWords = words.OrderByDescending(u => u.Value);

                    Console.WriteLine("ОТ САМЫХ ПОПУЛЯРНЫХ К МЕНЕЕ:");
                    foreach (var u in sortedWords)
                    {
                        Console.WriteLine(u.Key + "-" + u.Value);
                    }
                    Console.WriteLine("");
                    break;

                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            string text = "An international team of researchers has developed an innovative way " +
                "to interpret biological signals produced by the conduction of our skin. " +
                "To do this, they used data obtained using a wrist-worn sensor device. " +
                "An experiment was conducted in which a group of people used these technologies " +
                "for a month, not knowing about their intended purpose. Experience has shown " +
                "that people interpret their own results in different ways, with some monitoring " +
                "stress levels while others monitoring exercise and recovery. " +
                "An international team of researchers has developed an innovative way. way. way. way. way. way.";

            string[] word = text.Split(' ', '.', ',', '!', '?', ':', '-');

            Dictionary<string, int> words = new Dictionary<string, int>(word.Length);

            Analitics(word, words);

            //foreach (KeyValuePair<string, int> keyValue in words)
            //{
            //    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            //}

            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1 - слова, использующиеся чаще 13 раз, ");
            Console.WriteLine("2 - вывести слова по популярности использования.");

            try
            {
                int N = Int32.Parse(Console.ReadLine());
                SwitchAction(N, words);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

        }
    }
}
