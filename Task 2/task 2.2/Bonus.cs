using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    abstract class Bonus : Field
    {
        public Bonus(int x, int y) : base(x, y) { }

        public bool bonusReceived(int xPl, int yPl)
        {
            if (x == xPl && y == yPl)
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
