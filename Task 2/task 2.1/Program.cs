using System;

namespace task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str1 = "Hello World, I love you!";
            string str2 = "Hello Darya!";

            MyStringClass newString1 = new MyStringClass(str1);
            MyStringClass newString2 = new MyStringClass(str2);

            Console.WriteLine(str1.CompareTo(str2));

            Console.WriteLine(newString1.CompareTo(newString2));
        }
    }
}
