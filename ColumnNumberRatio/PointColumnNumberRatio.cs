using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetriminoWeek3Task.cs
{
    public abstract class PointColumnNumberRatio : Tetrimino
    {
        public override void PointInHitting()
        {
            int col = tetrimino[0].Length;
            int num = 0;
            for (int i = 0; i < tetrimino.Count; i++)
                num += tetrimino[i][col-1] == '.' ? 1 : 0;
            pointCode += col / num;
        }

    }
}
