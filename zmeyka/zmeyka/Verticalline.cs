﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeyka
{
    class Verticalline : Figure
    {
       
        public Verticalline(int yTop, int yBot, int x, char sym)

        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBot; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);



            }

        }

       
    }
}

    

