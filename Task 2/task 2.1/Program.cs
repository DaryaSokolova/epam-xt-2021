using System;
using System.Text;

namespace task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string str1 = "Hello World!";
            string str2 = "Hello Darya Sokolova!";

            MyStringClass newString1 = new MyStringClass(str1);
            MyStringClass newString2 = new MyStringClass(str2);

            //Console.WriteLine(str1.CompareTo(str2));
            //Console.WriteLine(newString1.CompareTo(newString2));

            //str1 = String.Concat(str1, str2);
            //Console.WriteLine(str1);

            //newString1= MyStringClass.Concat(newString1, newString2);
            //Console.WriteLine(newString1.getChars());

            //char ch = 'q';
            //Console.WriteLine(str1.LastIndexOf(ch));

            //Console.WriteLine(newString1.LastIndexOf(ch));

            //char[] arr1 = str1.ToCharArray();
            //Console.WriteLine(arr1);

            //char[] arr2 = newString1.ToCharArray();
            //Console.WriteLine(arr2);

            //char[] arr = new char[5];
            //char temp = 'a';

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = temp;
            //    temp++;
            //}

            //string str3 = String.Concat(arr);
            //Console.WriteLine(str3);

            //MyStringClass newString3 = MyStringClass.Concat(arr);
            //Console.WriteLine(newString3.getChars());

            str2 = str2.Insert(0, str1);
            Console.WriteLine(str2);

            newString2 = newString2.Insert(0, newString1);
            Console.WriteLine(newString2.getChars());

            //char ch = 'a';
            //str2 = str2.Insert(2, ch);
            //Console.WriteLine(str2);

            //newString2 = newString2.Insert(2, a);
            //Console.WriteLine(newString2.getChars());

        }
    }
}
