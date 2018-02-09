using System;

namespace myapp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 2;
            p1.y = 2;
            p1.sym = '#';

            p1.Draw();
        }
    }
}
