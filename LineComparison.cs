using System;

namespace LineComparison
{
	public class LineComparison
	{
		//Variables Declaration
		public int x1, y1, x2, y2;
		public String line;
		public static double length1, length2;

		/// <summary>
		/// Method for computing the length of lines
		/// </summary>
		/// <param name="line"></param>
		/// <param name="x1"></param>
		/// <param name="y1"></param>
		/// <param name="x2"></param>
		/// <param name="y2"></param>
		/// <returns></returns>
		public double lengthOfLine(String line, int x1, int y1, int x2, int y2)
		{

			Console.WriteLine("------------------------------------------------");
			double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			Console.WriteLine("End Points of Line Segments are = " + "(" + x1 + "," + y1 + ")" + "(" + x2 + "," + y2 + ")");
			Console.WriteLine("Length of " + line + " = " + length);
			return length;
		}
		
		/// <summary>
		/// Calling from main method
		/// </summary>
		/// <param name="args"></param>
		public static void Main(String[] args)
		{
			Console.WriteLine("<------Welcome to Line Comparison Program------>");
			LineComparison l1 = new LineComparison();
			double length1 = l1.lengthOfLine("Line 1", 7, 5, 3, 1);
			String str1 = Convert.ToString(length1);
			LineComparison l2 = new LineComparison();
			double length2 = l2.lengthOfLine("Line 2", 2, 4, 5, 0);
			String str2 = Convert.ToString(length2);
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine(str1.Equals(str2));//True or False
			Console.WriteLine(str1.CompareTo(str2));//prints 1
			Console.WriteLine(str2.CompareTo(str1));//prints -1
			Console.WriteLine("------------------------------------------------");
		}
	}
}
