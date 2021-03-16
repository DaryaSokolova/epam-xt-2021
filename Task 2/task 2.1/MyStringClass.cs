using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1
{
    class MyStringClass
    {

        private char[] chars;
        public MyStringClass(string str)
        {
            chars = str.ToCharArray();
        }

        public void writeChars()
        {
            foreach (char ch in chars)
            {

                Console.WriteLine(ch);
            }
        }

        public int Length
        {
            get
            {
                return chars.Length;
            }
        }

        public int CompareTo(MyStringClass strB)
        {

            if (this > strB)
            {
                return 1;
            }

            if (this < strB)
            {
                return -1;
            }

            return 0;
        }
        public static bool operator >(MyStringClass c1, MyStringClass c2)
        {
            for (int i = 0; i < c1.Length; i++)
            {
                if (c1.chars[i] != c2.chars[i])
                {
                    return c1.chars[i] > c2.chars[i];
                }

            }

            return false;
        }
        public static bool operator <(MyStringClass c1, MyStringClass c2)
        {
            for (int i = 0; i < c1.Length; i++)
            {
                if (c1.chars[i] != c2.chars[i])
                {
                    return c1.chars[i] < c2.chars[i];
                }

            }

            return false;
        }
    }
}
