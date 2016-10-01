using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zmeyka
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Horizontalline line = new Horizontalline(1, 75, 1, '#');

            line.Drow();

            Verticalline linev = new Verticalline(2, 23, 1, '#');

            linev.Drow();

            Horizontalline line2 = new Horizontalline(3, 75 ,23, '#');

            line2.Drow();

            Verticalline linev2 = new Verticalline(2, 23, 75, '#');

            linev2.Drow();

            Console.SetBufferSize(80, 25);

            Point p = new Point(3, 7, '*');

            Snake snake = new Snake(p, 5, Direction.RIGHT);

            snake.Drow();

            
            {
            FoodCreator foodCreator = new FoodCreator(78, 23, '&');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                    Thread.Sleep(100);
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.Handlekey(key.Key);
                    }
                    
                    
                }
            }


        }

    }
}

