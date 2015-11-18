using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Point p = new Point(20, 12, '$');
            Snake snake = new Snake( p, 4, Direction.RIGHT);
            snake.Drw();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(100);
                snake.Move();
            }
        }
        

    }

}
