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
			if (money == true)
			{
				return Math.Abs(x + y) != 1 ? $"{x + y} dollars" : $"{x + y} dollar";
			}
			else
			{
				return $"{x + y}";
			}

		}


		static void Main(string[] args)
		{
			Console.WriteLine(Program.Add(-1, 1, true));
			Console.WriteLine(Program.Add(2.1m, 1.4m));
			Console.WriteLine(Program.Add(3, 4));
		}
	}
}
