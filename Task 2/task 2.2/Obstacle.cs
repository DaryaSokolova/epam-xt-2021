﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    class Obstacle : Field
    {
        public Obstacle(int x, int y): base(x, y) { }

        public bool notMove(int xMove, int yMove)
        {
            if (x == xMove && y == yMove)
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
