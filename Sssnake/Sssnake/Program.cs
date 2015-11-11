using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sssnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 25, '*');
            VerticalLine rightLine = new VerticalLine(78, 0, 25, '*');

            upLine.Drw();
            downLine.Drw();
            leftLine.Drw();
            rightLine.Drw();

            Point p = new Point(20, 12, '>');
            Snake snake = new Snake( p, 4, Direction.RIGHT);
            snake.Drw();
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();

            Console.Write("G");
            System.Threading.Thread.Sleep(200);
            Console.Write("a");
            System.Threading.Thread.Sleep(200);
            Console.Write("m");
            System.Threading.Thread.Sleep(200);
            Console.Write("e");
            System.Threading.Thread.Sleep(200);
            Console.Write("O");
            System.Threading.Thread.Sleep(200);
            Console.Write("v");
            System.Threading.Thread.Sleep(200);
            Console.Write("e");
            System.Threading.Thread.Sleep(200);
            Console.Write("r");
            System.Threading.Thread.Sleep(200);
            Console.ReadLine();
        }
        

    }

}
