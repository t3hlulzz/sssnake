using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sssnake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yTop, int yBot, char sym)
        {
            pList = new List<Point>();

            for (int y = yTop; y < yBot; y++)

            {
                Point p2 = new Point(x, y, sym);

                pList.Add(p2);
            }
        }

            public void Drw2()
        {
            foreach (Point p2 in pList)
            {
                p2.Draw();
            }
        }
    }
}
