using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    class Troll : Monsters
    {
        public Troll (int x, int y):base(x,y) { }

        public override bool meetWithPlayer(Player player)
        {
            if (x == player.X && y == player.Y)
            {
                Console.WriteLine("Ты встретил тролля!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
