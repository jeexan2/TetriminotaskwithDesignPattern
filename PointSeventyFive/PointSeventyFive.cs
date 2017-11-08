using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetriminoWeek3Task.cs
{
    public abstract class PointSeventyFive : Tetrimino
    {
        public override void PointInHitting()
        {
            if (state == 3)
                pointCode += .75;   
        }

      
    }
}
