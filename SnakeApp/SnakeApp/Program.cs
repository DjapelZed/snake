using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(72, 19);
            Console.SetBufferSize(72, 19);
            //Делаем прямоугольник из #.        
            var horLine = new HorLines(1, 70, 1, '#');
            horLine.Draw();
            var horLineB = new HorLines(1, 70, 18, '#');
            horLineB.Draw();
            var vertLine = new VertLines(1, 1, 17, '#');
            vertLine.Draw();
            var vertLineR = new VertLines(70, 1, 17, '#');
            vertLineR.Draw();
            //Рисуем питона
            var p = new Point(20, 5, '*');
            p.Draw();
            var snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Console.ReadLine();
        }        
    }
}
