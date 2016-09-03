using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeApp
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            //Отрисовка змейки
            for(int i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.Hit(food))
            {
                head.Draw();
                food.symb = '*';
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void Move()
        {
            //Удаляем точку-хвост и добавляем точку-голова.
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);
            
            tail.Clear();
            head.Draw();            
        }
        //Обрабатываем получение новой точки
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            var nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void Control(ConsoleKey key)
        {
                if (key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
                    direction = Direction.LEFT;

                else if (key == ConsoleKey.RightArrow && direction != Direction.LEFT)
                    direction = Direction.RIGHT;

                else if (key == ConsoleKey.DownArrow && direction != Direction.UP)
                    direction = Direction.DOWN;

                else if (key == ConsoleKey.UpArrow && direction != Direction.DOWN)
                    direction = Direction.UP;
            
        }
    }
}
