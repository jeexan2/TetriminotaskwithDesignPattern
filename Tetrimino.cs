using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetriminoWeek3Task.cs
{
    public abstract class Tetrimino : ITetrimino
    {
        protected List<string> tetrimino = new List<string>();
        public double pointCode { get; set; }
        public int state { get; set; }
        public abstract void Init();
        public virtual void PointInHitting() { }
       

        public void Rotate()
        {
            int row, col;
            row = tetrimino[0].Length;
            col = tetrimino.Count;
     
           
            List<string> newTetrimino = new List<string>();
            for (int i = 0; i < col; i++)
            {
                string str = "";
                for (int j = 0; j < row; j++)
                {
                    str += tetrimino[i][j];
                }
                newTetrimino.Add(str);
            }
           
            tetrimino = newTetrimino;
            state++;
            state %= 4;
            state = state < 0 ? state += 5 : state + 1;
        }
        public void CounterClockwiseRotation()
        {
            state -= 1;
            state = state < 0 ? state + 4 : state;
            List<string> transposedTetrimino = new List<string>();
            int row, col;
            row = tetrimino[0].Length;
            col = tetrimino.Count;
            //Transposing matrix
            for (int i = 0; i < col; i++)
            {
                string str = "";
                for (int j = 0; j < row; j++)
                    str += tetrimino[i][j];
                transposedTetrimino.Add(str);
            }
            tetrimino = null;
            foreach (var str in transposedTetrimino)
            {
                var inputStr = str.Reverse();
                tetrimino.Add(inputStr.ToString());

            }
        }
        private void LoopStateChanger(int st,int ed)
        {
            for (int i = st; i <= ed; i++)
                Rotate();
        }    
        public void StateChange(int initialState,int targetState)
        {
            if (initialState > targetState)
                LoopStateChanger(targetState, initialState);
            else LoopStateChanger(initialState, targetState);
        }
    }
}
