using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp
{
    class HorLines
    {
        List<Point> pList;
        public HorLines(int xL, int xR, int y, char symb)
        {
            pList = new List<Point>();
            for(int x = xL; x <= xR; x++)
            {
                Point p = new Point(x , y , symb);
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
