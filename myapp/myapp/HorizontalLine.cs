using System;
using System.Collections.Generic;

namespace myapp
{
    public class HorizonatalLine
    {
        List<Point> pList;

        public HorizonatalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }

        public void Draw()
        {
            foreach(int p in pList)
            {
                p.Draw();
            }
        }
    }
}
