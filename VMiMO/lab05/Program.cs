// ReSharper disable UnusedParameter.Local

using System;
using labs.Calculations;
using labs.Entities;
using labs.Helpers;

namespace lab05
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			var interval = new Interval
				{
					//A = -1,
					//B = 3,
					A = -4.2,
					B = 5.2,
					Eps = 0.0001,
					Inc = 0.0001,
					//Function = new MathematicalFunction { Value = x => x * x - 10 * Math.Pow(Math.Sin(x), 2) + 2 }
					Function = new MathematicalFunction { Value = x => Math.Sin(Math.PI * x) }
				};

			Console.WriteLine("Корни: ");
			Console.WriteLine(interval.Roots(PrettyPrint.True));
		}
	}
}
// ReSharper restore UnusedParameter.Local