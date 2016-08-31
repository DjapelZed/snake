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
            var p1 = new Point(2,2,'*');
            p1.Draw();            
            var p2 = new Point(4,4,'#');
            p2.Draw();

            var horLine = new HorLines(6, 13, 7, '*');
            horLine.Draw();

            var vertLine = new VertLines(5, 7, 14, '*');
            vertLine.Draw();

            Console.ReadLine();
        }        
    }
}
