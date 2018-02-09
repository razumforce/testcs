using System;
using System.Collections.Generic;

namespace myapp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 20);
            HorizontalLine hLine = new HorizontalLine(4, 7, 8, '=');

            VerticalLine vLine = new VerticalLine(4, 7, 8, '+');

            vLine.pList[0].x = 5;

            hLine.Draw();
            vLine.Draw();
        }

    }
}
