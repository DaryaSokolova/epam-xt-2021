using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_3._3._2
{
    public static class MySuperString
    {
        public static string WhatLanguage(this string str)
        {
            char[] chars = str.ToCharArray();

            bool engString = chars.All(ch => (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'));
            bool rusString = chars.All(ch => (ch >= 'а' && ch <= 'я') || (ch >= 'А' && ch <= 'Я'));
            bool numString = chars.All(ch => (ch >= '0' && ch <= '9'));

            if(engString == true && rusString == false && numString == false)
            {
                return "English";
            }

            if (engString == false && rusString == true && numString == false)
            {
                return "Russian";
            }

            if (engString == false && rusString == false && numString == true)
            {
                return "Numbers";
            }

            return "Mixed";
        }


    }
}
