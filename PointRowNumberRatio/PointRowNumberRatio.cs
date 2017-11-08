using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetriminoWeek3Task.cs
{
   public abstract class PointRowNumberRatio : Tetrimino
    {
        

        public override void PointInHitting()
        {
            int row = tetrimino.Count;
            int num = 0;
            for (int i = 0; i < tetrimino[0].Length; i++)
                num += tetrimino[row][i] == '.' ? 1 : 0;
            pointCode += row / num;
        }

      
    }
}
