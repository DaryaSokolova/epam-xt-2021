using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    interface IMove
    {
        void Move(int x, int y, Stone o1, Tree o2);

        int MoveX(int x, Stone o1, Tree o2);

        int MoveY(int y, Stone o1, Tree o2);
    }
}
