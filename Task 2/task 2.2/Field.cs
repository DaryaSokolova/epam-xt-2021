using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    abstract class Field
    {
        protected int Width = 10;
        protected int Height = 10;

        protected int x = 0;
        protected int y = 0;

        public int X
        {
            get
            {
                return x;
            }

            protected set
            {
                if (x < 0 || x > Width)
                {
                    throw new Exception("Выход за границы поля!");
                }
                else
                {
                    x = value;
                }
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            protected set
            {
                if (y < 0 || y > Height)
                {
                    //выброс исключения
                }
                else
                {
                    y = value;
                }
            }
        }

        public Field(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Field()
        {

        }
    }
}
