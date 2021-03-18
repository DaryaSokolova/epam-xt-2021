using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    interface IMove
    {
        void Move(int x, int y, Obstacle o1, Obstacle o2);

        int MoveX(int x, Obstacle o1, Obstacle o2);

        int MoveY(int y, Obstacle o1, Obstacle o2);
    }
}
