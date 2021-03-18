using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    class Player : Field, IMove
    {
        private int health = 5;

        public int Health
        {
            get
            {
                return health;
            }

            private set
            {
                if (value > 10)
                {
                    throw new Exception("-Запас здоровья полон!-");
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
                    throw new Exception("Где вы видели отрицательное натуральное число?");
                }
                else
                {
                    countFlower = value;
                }
            }
        }

        public void Move(int x, int y, Stone o1, Tree o2)
        {

            //Console.WriteLine("Игрок двигается");

            X = MoveX(x, o1, o2);
            Y = MoveY(y, o1, o2);

        }

        public int MoveX(int x1, Stone o1, Tree o2)
        {

            if ((x + x1 < 0 || x + x1 > Width) || (o1.notMove(x + x1, y) == true) || ((o2.notMove(x + x1, y) == true)))
            {
                throw new Exception("*Удар об стенку или препятствие*");
            }
            else
            {
                x += x1;
            }

            return x;
        }

        public int MoveY(int y1, Stone o1, Tree o2)
        {

            if ((y + y1 < 0 || y + y1 > Height) || (o1.notMove(x, y + y1) == true) || (o2.notMove(x, y + y1) == true))
            {
                throw new Exception("*Удар об стенку или препятствие*");
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
