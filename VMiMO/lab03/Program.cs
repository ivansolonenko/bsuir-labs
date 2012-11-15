// ReSharper disable UnusedParameter.Local

using System;
using labs.Calculations;
using labs.Entities;
using labs.Helpers;

namespace lab03
{
	static class Program
	{
		static void Main(string[] args)
		{
			var integral = new Integral
			{
				A = 3,
				B = 6,
				N = 1000,
				H = 0.001,
				K = 10000,
				Function = new MathematicalFunction { Value = x => Math.Log(x) - 5 * Math.Pow(Math.Sin(x), 2) },
				FirstDerivative = new MathematicalFunction { Value = x => 1 / x - 5 * Math.Sin(2 * x) },
				SecondDerivative = new MathematicalFunction { Value = x => -1 / Math.Pow(x, 2) - 10 * Math.Cos(2 * x) }
				//Function = new MathematicalFunction { Value = x => 4 * x * x * x },
				//FirstDerivative = new MathematicalFunction { Value = x => 12 * x * x },
				//SecondDerivative = new MathematicalFunction { Value = x => 24 * x }
			};

			Console.WriteLine("Интеграл равен {1:0.000} при количестве шагов {2}.{0}", Environment.NewLine, integral.Integrate(), integral.N);
			Console.WriteLine("Первая производная:{0}{1}", Environment.NewLine, integral.Differentiate(1, 10, PrettyPrint.True));
			Console.WriteLine("Вторая производная:{0}{1}", Environment.NewLine, integral.Differentiate(2, 10, PrettyPrint.True));
		}
	}
}
// ReSharper restore UnusedParameter.Local
