using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    class Player : Field, IMove
    {
        private int health = 90;

        public int Health
        {
            get
            {
                return health;
            }

            private set
            {
                if (value > 100)
                {
                    //?????
                }
                else
                {
                    health = value;

                }
            }
        }

        private int countFlower = 0;

        public int CountFlower
        {
            get
            {
                return countFlower;
            }

            private set
            {
                if (countFlower < 0)
                {
                    ///????
                }
                else
                {
                    countFlower = value;
                }
            }
        }

        public void Move(int x, int y)
        {

            //Console.WriteLine("Игрок двигается");

            X = MoveX(x);
            Y = MoveY(y);

        }

        public int MoveX(int x1)
        {

            if (x + x1 < 0 || x + x1 > Width)
            {
                //?????
            }
            else
            {
                x += x1;
            }

            return x;
        }

        public int MoveY(int y1)
        {

            if (y + y1 < 0 || y + y1 > Height)
            {
                //?????
            }
            else
            {
                y += y1;
            }

            return y;
        }

        public Player(int x, int y) : base(x, y) { }

        public Player() { }

        public int getApple()
        {
            return health++;
        }

        public int getFlower()
        {
            return countFlower++;
        }

        public int getHurt()
        {
            return health--;
        }

    }
}
