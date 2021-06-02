using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public class LineComparison
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("<------Welcome to Line Comparison Program------>");
            Console.WriteLine("------------------------------------------------");
            //Variables
            int x1, y1, x2, y2;

            //LineComparison line = new LineComparison();

            // User inputs the coordinates
            Console.WriteLine("Enter 1st co-ordinate of x-axis of First Line : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st co-ordinate of y-axis of First Line : ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd co-ordinate of x-axis of First Line : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd co-ordinate of y-axis of First Line : ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("End Points of First Line Segment are = " + "(" + x1 + "," + y1 + ")" + "(" + x2 + "," + y2 + ")");
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of a First Line Segment = " + length1);
        }
    }
}