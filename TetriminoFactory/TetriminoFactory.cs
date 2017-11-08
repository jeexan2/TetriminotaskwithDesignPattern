using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetriminoWeek3Task.cs
{
    public  class TetriminoFactory 
    {
        public ITetrimino TetriminoCreator(string input)
        {
            if (input[0] == 'T')
            {
                //Constructor gula thik kora lagbe
                return new ShapeTTetrimino(input[1]);
            }
            else if (input[0] == 'O')
            {
                return new ShapeSTetrimino(input[1]);
            }
            else if (input[0] == 'I')
            {
                return new ShapeITetrimino(input[1]);
            }
            else if (input[0] == 'Z')
            {
                return new ShapeZTetrimino(input[1]);
            }
            else if (input[0] == 'S')
            {
                return new ShapeSTetrimino(input[1]);
            }
            else if (input[0] == 'J')
            {
                return new ShapeJTetrimino(input[1]);
            }
            else if (input[0] == 'L')
            {
                return new ShapeLTetrimino(input[1]);
            }
            else return null;
        }
    }
}
