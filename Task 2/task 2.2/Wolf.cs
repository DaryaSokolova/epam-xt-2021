using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    class Wolf : Monsters, IMove
    {
        public Wolf(int x, int y) : base(x, y) { }

        public override bool meetWithPlayer(Player player)
        {
            if (x == player.X && y == player.Y)
            {
                Console.WriteLine("Ты встретил волка!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
