using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_3._3._1
{
    public static class MySuperArray
    {
        public static void MyForeach<T>(this T[] arr, Func<T, T> func)
        {
            if (func != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = func(arr[i]);
                    Console.WriteLine(arr[i]);
                }
            }
        }

        public static int MySum(this int[] value) => value.Sum();
        public static double MySum(this double[] value) => value.Sum();
        public static float MySum(this float[] value) => value.Sum();
        public static byte MySum(this byte[] value)
        {
            byte sumTemp = 0;

            for (int i = 0; i < value.Length; i++)
            {
                sumTemp += value[i];
            }

            return sumTemp;
        }
        public static short MySum(this short[] value)
        {
            short sumTemp = 0;

            for (int i = 0; i < value.Length; i++)
            {
                sumTemp += value[i];
            }

            return sumTemp;
        }

        public static int MyAverage(this int[] value) => (int)value.Average();
        public static double MyAverage(this double[] value) => (double)value.Average();
        public static float MyAverage(this float[] value) => (float)value.Average();
        public static byte MyAverage(this byte[] value)
        {
            byte sumTemp = MySum(value);

            return (byte)(sumTemp / value.Length);
        }
        public static short MyAverage(this short[] value)
        {
            short sumTemp = MySum(value);

            return (short)(sumTemp / value.Length);
        }

        public static T MostFrequent<T>(this T[] value)
        {
            return value.GroupBy(x => x)
                        .OrderBy(x => x.Count())
                        .Last().Key;
        }
    }
}
