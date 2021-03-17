﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1
{
    class MyStringClass11111
    {

        private char[] chars { get; set; }

        public MyStringClass11111(char[] _chars)
        {
            chars = _chars;
        }

        public MyStringClass11111(string str)
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

        public int CompareTo(MyStringClass11111 strB)
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

        public static bool operator >(MyStringClass11111 c1, MyStringClass11111 c2)
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

        public static bool operator <(MyStringClass11111 c1, MyStringClass11111 c2)
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

        public static char[] operator +(MyStringClass11111 c1, MyStringClass11111 c2)
        {
            char[] temp = new char[c1.Length + c2.Length];

            for (int i = 0; i < c1.Length; i++)
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

        public static MyStringClass11111 Concat(MyStringClass11111 strA, MyStringClass11111 strB)
        {
            MyStringClass11111 str = new MyStringClass11111(strA + strB);

            return str;
        }
        public static MyStringClass11111 Concat(char[] arr)
        {
            MyStringClass11111 temp = new MyStringClass11111(arr);

            return temp;
        }

        public int IndexOf(char ch)
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (this.chars[i] == ch)
                {
                    return i;
                }
            }

            return -1;
        }

        public int LastIndexOf(char ch)
        {
            for (int i = this.Length - 1; i > 0; i--)
            {
                if (this.chars[i] == ch)
                {
                    return i;
                }
            }

            return -1;
        }

        public char[] ToCharArray()
        {
            return this.getChars();
        }

        public MyStringClass11111 Insert(int index, MyStringClass11111 str)
        {
            char[] temp = new char[this.Length + str.Length];

            if (index != 0)
            {

                for (int i = 0; i < index; i++)
                {
                    temp[i] = this.chars[i];
                }

                int tempCount = 0;
                for (int i = index; i < index + str.Length; i++)
                {
                    temp[i] = str.chars[tempCount++];
                }

                if (temp.Length != index + str.Length)
                {

                    tempCount = index;
                    for (int i = index + str.Length; i < temp.Length; i++)
                    {
                        temp[i] = this.chars[tempCount++];
                    }
                }
            }
            else
            {
                for (int i = index; i < index + str.Length; i++)
                {
                    temp[i] = str.chars[i];
                }

                if (temp.Length != index + str.Length)
                {

                    int tempCount = 0;
                    for (int i = index + str.Length; i < temp.Length; i++)
                    {
                        temp[i] = this.chars[tempCount++];
                    }
                }
            }

            MyStringClass11111 tempObject = new MyStringClass11111(temp);
            return tempObject;
        }
    }
}
