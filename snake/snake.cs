using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class snake
    {
        public List<Cell> TheSnake = new List<Cell>();
        public List<int> XPos = new List<int>();
        public List<int> YPos = new List<int>();
        public int lastCell = 0;
        public void CreateNewCell()
        {

            this.TheSnake.Add(new Cell());
            lastCell++;
           
                this.TheSnake[lastCell].x = this.TheSnake[lastCell - 1].x;
                this.TheSnake[lastCell].y = this.TheSnake[lastCell - 1].y;
                this.TheSnake[lastCell].color = this.TheSnake[lastCell - 1].color;
                this.TheSnake[lastCell].width = this.TheSnake[lastCell - 1].width;
                this.TheSnake[lastCell].height = this.TheSnake[lastCell - 1].height;
            
           
            
        }
        public void MoveAllSnakeCells()
        {
            for (int i = 0; i < this.TheSnake.Count-1; i++)
            {
                this.TheSnake[i+1].x = this.XPos[i];
                this.TheSnake[i+1].y = this.YPos[i];

            }
        }
    }
}
