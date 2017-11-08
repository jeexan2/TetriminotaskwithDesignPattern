using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetriminoWeek3Task.cs
{
    public abstract class PointFiveDownwards : Tetrimino
    {
        public override void PointInHitting()
        {
            pointCode += 0.5;
        }
       
      
    }
}
