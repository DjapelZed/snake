using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp
{
    class Walls
    {
        List<Figure> wallList;
        public Walls()
        {
            wallList = new List<Figure>();
            //Делаем прямоугольник из #.        
            var horLine = new HorLines(1, 70, 1, '#');
            horLine.Draw();
            var horLineB = new HorLines(1, 70, 18, '#');
            horLineB.Draw();
            var vertLine = new VertLines(1, 1, 17, '#');
            vertLine.Draw();
            var vertLineR = new VertLines(70, 1, 17, '#');
            vertLineR.Draw();

            wallList.Add(horLine);
            wallList.Add(horLineB);
            wallList.Add(vertLine);
            wallList.Add(vertLineR);
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
