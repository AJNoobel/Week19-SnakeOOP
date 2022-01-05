using System;
using System.Collections.Generic;
namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10, '*');
            Point p2 = new Point(11, 10, '*');


            HorizontalLine hLine = new HorizontalLine(10, 14, 5, '*');
            hLine.Draw();
            VerticalLine vLine = new VerticalLine(6, 16, 10, '@');
            vLine.Draw();


            HorizontalLine top = new HorizontalLine(0, 80, 0, '#');
            top.Draw();
            Console.ReadLine();
            VerticalLine left = new VerticalLine(0, 25, 0, '#');
            left.Draw();
        }

        

    }
}
