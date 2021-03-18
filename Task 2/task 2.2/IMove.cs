using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._2
{
    interface IMove
    {
        void Move(int x, int y);

        int MoveX(int x);

        int MoveY(int y);
    }
}
