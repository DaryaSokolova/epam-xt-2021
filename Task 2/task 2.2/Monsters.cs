using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    abstract class Monsters : Field, IMove
    {
        public Monsters(int x, int y) : base(x, y) { }

        public void Move(int x, int y, Obstacle o1, Obstacle o2)
        {
            //Console.WriteLine("Монстр двигается");

            X = MoveX(x, o1, o2);
            Y = MoveY(y, o1, o2);
        }

        public int MoveX(int x1, Obstacle o1, Obstacle o2)
        {

            if ((x + x1 < 0 || x + x1 > Width) || (o1.notMove(x + x1, y) == true) || (o2.notMove(x + x1, y) == true))
            {
                //?????
            }
            else
            {
                x += x1;
            }

            return x;
        }

        public int MoveY(int y1, Obstacle o1, Obstacle o2)
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
