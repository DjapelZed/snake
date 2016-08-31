using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp
{
    class VertLines
    {
        List<Point> pList;
        public VertLines(int x, int yT, int yB, char symb)
        {
            pList = new List<Point>();
            for(int y = yT; y <= yB; y++)
            {
                Point p = new Point(x, y, symb);
                pList.Add(p);
            }
        }
        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }

        }
    }
}
