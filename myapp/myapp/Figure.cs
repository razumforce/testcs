﻿using System;
using System.Collections.Generic;

namespace myapp
{
    public class Figure
    {
        public List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
