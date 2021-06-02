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
            int x1, y1, x2, y2, x3, y3, x4, y4;
            
            // User inputs the coordinates
            Console.WriteLine("Enter 1st co-ordinate of x-axis of First Line : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st co-ordinate of y-axis of First Line : ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd co-ordinate of x-axis of First Line : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd co-ordinate of y-axis of First Line : ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a 1st co-ordinate of x-axis of Second Line : ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a 1st co-ordinate of y-axis of Second Line : ");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a 2nd co-ordinate of x-axis of Second Line : ");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a 2nd co-ordinate of y-axis of Second Line : ");
            y4 = Convert.ToInt32(Console.ReadLine());

            //Print the coordinates
            Console.WriteLine("End Points of First Line Segment are = " + "(" + x1 + "," + y1 + ")" + "(" + x2 + "," + y2 + ")");
            Console.WriteLine("End Points of Second Line Segment are = " + "(" + x3 + "," + y3 + ")" + "(" + x4 + "," + y4 + ")");
            
            // Convert double into String
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            String str1 = Convert.ToString(length1);
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            String str2 = Convert.ToString(length2);
            // Prints length of 2 line segment
            Console.WriteLine("Length of a First Line Segment = " + length1);
            Console.WriteLine("Length of a Second Line Segment = " + length2);
            // Using equals method to check equality of 2 lengths
            Console.WriteLine(str1.Equals(str2));
        }
    }
}
