using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    class Tree : Obstacle
    {
        public Tree(int x, int y) : base(x, y) { }

        public override bool notMove(int xMove, int yMove)
        {
            if (x == xMove && y == yMove)
            {
                Console.WriteLine("Ой, тут дерево!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
