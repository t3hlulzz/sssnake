﻿using System;
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

            Point p1 = new Point(1, 3, '*');
                       p1.Draw();

            Point p2 = new Point(4, 5, '#');
                      p2.Draw();

            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);
            numlist.Add(3);
            numlist.Add(4);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            foreach(int i in numlist)
            {
                Console.WriteLine(i);
            }

            /*numlist.RemoveAt(0);

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);*/

            Console.WriteLine("=====");

            List<char> charlist = new List<char>();
            charlist.Add('#');
            charlist.Add('*');

            foreach(char i in numlist)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
        

    }

}
