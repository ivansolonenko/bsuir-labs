using System;
using labs.Helpers;

namespace lab08
{
	static class Program
	{
		const int N = 3;
		const double E = 0.001;
		const double EE = 0.00001;
		const double D_SOURCE = 2;
		static readonly double GOLDEN = (3 - Math.Sqrt(5)) / 2;
		static double[] D;

		static double Func(double[] x)
		{
			var theta = Math.Atan(x[1] / x[0]);
			var r = Math.Sqrt(Math.Pow(x[0], 2) + Math.Pow(x[1], 2));
			return 100 * (Math.Pow(x[2] - 10 * theta, 2) + Math.Pow(r - 1, 2)) + Math.Pow(x[2], 3) + BarierFunc(x);
			//return 100 * (x[0] - 1) * (x[0] - 1) + (x[1] - 2) * (x[1] - 2) + (x[2] - 3) * (x[2] - 3) + BarierFunc(x);
		}

		static double BarierFunc(double[] x)
		{
			const double max = 0.5;
			return x[0] < max ? 0 : 100 * (x[0] - max);
		}

		static bool IsMin()
		{
			for (var i = 0; i < N; ++i)
				if (D[i] > E)
					return false;
			return true;
		}

		static void Calc(double[] x0)
		{
			do
			{
				var m = 0;
				for (var i = 0; i < N; ++i)
				{
					var x = (double[])x0.Clone();
					x[i] += D[i];
					if (Func(x) < Func(x0))
					{
						x0[i] = x[i];
					}
					else
					{
						x[i] = x0[i] - D[i];
						if (Func(x) < Func(x0))
							x0[i] = x[i];
						else
							++m;
					}
				}
				if (N == m)
					for (var i = 0; i < N; ++i)
						D[i] = D[i] / 2;
			} while (!IsMin());
		}

		static void Golden(double[] x0)
		{
			for (var k = 0; k < N; ++k)
			{
				var a = x0[k] - E;
				var b = x0[k] + E;
				var x1 = (double[])x0.Clone();
				while (Math.Abs(b - a) > EE)
				{
					x0[k] = a + GOLDEN * (b - a);
					x1[k] = b - GOLDEN * (b - a);
					if (Func(x0) > Func(x1))
						a = x0[k];
					else
						b = x1[k];
				}
			}
		}

		// ReSharper disable UnusedParameter.Local
		static void Main(string[] args)
		// ReSharper restore UnusedParameter.Local
		{
			var x0 = new double[N];
			Console.WriteLine("Начальная точка: ");
			for (var i = 0; i < N; ++i)
			{
				Console.Write("X[" + i + "] = ");
				x0[i] = Helpers.StringToNumber<double>(Console.ReadLine());
			}

			D = new double[N];
			for (var i = 0; i < N; ++i)
				D[i] = D_SOURCE;

			Calc(x0);
			Golden(x0);

			Console.Write("Результат: (");
			for (var i = 0; i < N; ++i)
				Console.Write(x0[i] + " ");
			Console.WriteLine(")");
		}
	}
}
