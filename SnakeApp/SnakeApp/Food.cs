using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp
{
    class Food
    {
        int mapH;
        int mapW;
        char symb;
        Random random = new Random();
        public Food(int mapH, int mapW, char symb)
        {
            this.mapH = mapH;
            this.mapW = mapW;
            this.symb = symb;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapW - 2);
            int y = random.Next(2, mapH - 2);
            return new Point(x, y, symb);
        }
    }
}
