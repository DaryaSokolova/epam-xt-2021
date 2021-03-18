using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    abstract class Monsters : Field, IMove
    {
        public Monsters(int x,int y): base(x, y) { }

        public void Move(int x, int y)
        {
            //Console.WriteLine("Монстр двигается");

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

        public virtual bool meetWithPlayer(Player player)
        {
            if (x == player.X && y == player.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
