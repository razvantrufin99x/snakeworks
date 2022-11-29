using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public  class Cell
    {
        public int x;
        public int y;
        public Color color;
        public float width;
        public float height;
        public Cell() { }
        public Cell(int px, int py, Color pcolor, float pw, float ph) 
        {
            x = px;
            y = py;
            color = pcolor;
            width = pw;
            height = ph;

        }
        
    }
}
