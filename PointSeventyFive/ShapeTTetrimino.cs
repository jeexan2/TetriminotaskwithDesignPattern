﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetriminoWeek3Task.cs
{
    public class ShapeTTetrimino : PointSeventyFive
    {
        public override void Init()
        {
            this.tetrimino.Add("...");
            this.tetrimino.Add(" . ");
            state = 1;
            pointCode = 0;
        }
        public ShapeTTetrimino(char ch)
        {
            int state = Convert.ToInt32(ch);
            Init();
            StateChange(1, state);
        }
    }
}
