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

            HorizontalLine bucks = new HorizontalLine(6, 9, 10, '$');
            bucks.Drw();
                       
            Console.ReadLine();
        }
        

    }

}
