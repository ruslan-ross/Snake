using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //Отрисовка рамки
            HorizontalLines upline = new HorizontalLines(0, 78, 0, '+');
            HorizontalLines downline = new HorizontalLines(0, 78, 24, '+');
            Verticallines leftline = new Verticallines(0, 24, 0, '+');
            Verticallines rightline = new Verticallines(0, 24, 78, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');

            Console.ReadLine();
        }
    }
}
