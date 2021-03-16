using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1
{
    class MyStringClass
    {

        private char[] chars;

        public MyStringClass(char[] _chars)
        {
            chars = _chars;
        }

        public MyStringClass(string str)
        {
            chars = str.ToCharArray();
        }

        public char[] getChars()
        {
            return chars;
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

        public static char[] operator +(MyStringClass c1, MyStringClass c2)
        {
            char[] temp = new char[c1.Length+c2.Length];

            for (int i = 0; i < c1.Length ; i++)
            {
                temp[i] = c1.chars[i];
            }

            int tempCount = 0;

            for (int i = c1.Length; i < c1.Length + c2.Length; i++)
            {
                temp[i] = c2.chars[tempCount++];
            }

            return temp;
        }

        public static MyStringClass Concat(MyStringClass strA, MyStringClass strB)
        {
            MyStringClass str = new MyStringClass(strA + strB);

            return str;
        }

        public int IndexOf(char ch)
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (this.chars[i]==ch)
                {
                    return i;
                }
            }

            return -1;
        }

        public int LastIndexOf(char ch)
        {
            for (int i = this.Length-1; i > 0; i--)
            {
                if (this.chars[i] == ch)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
