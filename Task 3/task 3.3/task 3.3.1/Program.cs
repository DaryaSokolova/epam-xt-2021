using System;

namespace task_3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            byte[] arr = new byte[] { 1, 2, 5, 76, 5, 7 };

            //arr.MyForeach(MyLoveValue);

            Console.WriteLine(arr.MySum());

            Console.WriteLine(arr.MyAverage());

            Console.WriteLine(arr.MostFrequent());
        }

        public static int MyLoveValue(int item) => (int)(item * 100);
        public static int MyHateValue(int item) => (int)(item / 2);

        public static float MyLoveValue(float item) => (float)(item * 100);
        public static float MyHateValue(float item) => (float)(item / 2);

        public static double MyLoveValue(double item) => (double)(item * 100);
        public static double MyHateValue(double item) => (double)(item / 2);

        public static byte MyLoveValue(byte item) => (byte)(item * 100);
        public static byte MyHateValue(byte item) => (byte)(item / 2);

        public static short MyLoveValue(short item) => (short)(item * 100);
        public static short MyHateValue(short item) => (short)(item / 2);
    }

}
