using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace task_4._1
{
    internal sealed class Program
    {
        enum ForSwitch
        {
            watch,
            reset
        }

        private static void Selection(int s)
        {
            switch (s)
            {
                case (int)ForSwitch.watch:
                    DisplayObservation();
                    break;

                case (int)ForSwitch.reset:
                    СancelСhanges();
                    break;

                default:
                    Console.WriteLine("Я не знаю такой команды :(");
                    break;
            }
        }

        private static void ModeSelection()
        {
            while (true)
            {

                Console.WriteLine("0 - watch");
                Console.WriteLine("1 - reset");

                try
                {
                    int selection = Convert.ToInt32(Console.ReadLine());
                    Selection(selection);
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Введено не число или что-то пошло не так, повтори попытку..");
                }

            }
        }

        private static void GetInfoAboutDirectory(string dirName)
        {
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);

                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);

                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
        }

        private static void DisplayObservation()
        {
            Console.WriteLine(" ~ WATCH ~ ");
            Console.WriteLine($"Я слежу за папкой: {NewDirectory.FileFolder}");
            GetInfoAboutDirectory((string)NewDirectory.FileFolder);
            CheckClass.View();

            Console.WriteLine("Не забудь нажать на любую клавишу..");
            Console.ReadKey();

            Process.Start(Assembly.GetExecutingAssembly().Location);
            Environment.Exit(0);
        }

        private static void СancelСhanges()
        {
            bool fl = true;

            Console.WriteLine(" ~ RESET ~ ");

            Console.WriteLine("К какому времени откатить?");
            Console.WriteLine("дд.мм.гггг чч:мм:сс");

            DateTime date;

            if (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Ввод неверный!");
                fl = false;
            }

            if (fl == true)
            {
                ResetClass.RollBack(date);
                Console.WriteLine("Успешно!");
            }

            Console.WriteLine("Не забудь нажать на любую клавишу..");
            Console.ReadKey();
        }
        private static void Main(string[] args)
        {
            NewDirectory.CreateSourceFilesAndFolders();
            ModeSelection();
        }

    }
}
