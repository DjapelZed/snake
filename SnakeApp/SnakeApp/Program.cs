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
            var p1 = new Point();
            p1.x = 2;
            p1.y = 2;
            p1.symb = '*';
            p1.Draw();

            var p2 = new Point();
            p2.x = 4;
            p2.y = 4;
            p2.symb = '#';
            p2.Draw();

            Console.ReadLine();
        }        
    }
}
