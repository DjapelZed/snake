using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(72, 19);
            Console.SetBufferSize(72, 19);

            //Рисуем питона
            var p = new Point(10, 5, '*');
            int l = 2;
            var snake = new Snake(p, l, Direction.RIGHT);
            snake.Draw();
            Walls wall = new Walls();

            Food foodCreator = new Food(17, 70, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
               
            while (true)
            {
                if (wall.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.Control(key.Key);
                }
                Thread.Sleep(150);
                snake.Move();
            }           
        }        
    }
}
