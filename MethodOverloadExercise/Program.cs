using System;

namespace MethodOverloadExercise
{
    class Program
    {
		static int Add(int x, int y)
		{
			return x + y;
		}
		static decimal Add(decimal x, decimal y)
		{
			return x + y;
		}
		static string Add(int x, int y, bool money)
		{
			return (money == true && Math.Abs(x + y) != 1) ? $"{x + y} dollars" : $"{x + y} dollar";
		}
		static void Main(string[] args)
		{
			Console.WriteLine(Program.Add(0, 1, true));
		}
	}
}
