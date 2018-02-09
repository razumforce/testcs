using System;
using System.Collections.Generic;

namespace myapp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Point> pList = new List<Point>();


            pList.Add(new Point(1, 2, '%'));

            pList[0].Draw();
        }

    }
}
