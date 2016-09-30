using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeyka
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 3, '*');
        
            p1.Draw();


            Point p2 = new Point(3, 6, '*');
           
            p2.Draw();

            Horizontalline line = new Horizontalline(1, 40, 1, '#');

            line.Drow();

            Verticalline linev = new Verticalline(2, 20, 1, '#');

            linev.Drow();

            Horizontalline line2 = new Horizontalline(3, 40, 20, '#');

            line2.Drow();

            Verticalline linev2 = new Verticalline(2, 20, 40, '#');

            linev2.Drow();
           







            Console.ReadLine();
        }

    }
}

