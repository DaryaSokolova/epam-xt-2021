using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    class Stone : Obstacle
    {
        public Stone(int x, int y) : base(x, y) { }

        public override bool notMove(int xMove, int yMove)
        {
            if (x == xMove && y == yMove)
            {
                Console.WriteLine("Вау, это камень!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
