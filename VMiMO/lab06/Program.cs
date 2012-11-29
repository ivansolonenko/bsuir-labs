using System;

namespace lab06
{
	static class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("f1(x,u1,u2)=2*x/u1+u2/exp(x)");
			Console.WriteLine("f2(x,u1,u2)=u1*exp(x)/(2*x)");

			const int a = 3;
			const int b = 4;
			const int n = 10;
			const double h = (double)(b - a) / (n - 1);
			var u1 = new double[n];
			u1[0] = 2 * a;
			var u2 = new double[n];
			u2[0] = Math.Exp(a);

			var x = new double[n];
			for (int i = 0; i < n; i++) // Шаг
				x[i] = a + i * h;

			var mas1 = new double[n];
			var mas2 = new double[n];

			Console.WriteLine("u1(a)=" + u1[0]);
			Console.WriteLine("u2(a)=" + u2[0]);
			Console.WriteLine("a=" + a);
			Console.WriteLine("b=" + b);
			Console.WriteLine("n=" + n);
			Console.WriteLine("h=" + string.Format("{0:0.0000}", h));

			// Вычисление приближенных значений
			CountValues(u1, u2, x, n, h);

			// Вычисление точных значений
			CountFun(mas1, mas2, x, n);

			Console.WriteLine("\nТаблица значений:");
			Console.WriteLine("\tx \t\tu1(x) \t\tu1(x)точ \tu2(x) \t\tu2(x)точ");
			for (var i = 0; i < n; i++)
				Console.WriteLine("{0}\t{1:0.000000}\t{2:0.000000}\t{3:0.000000}\t{4:0.000000}\t{5:0.000000}",
					(i + 1), x[i], u1[i], mas1[i], u2[i], mas2[i]);
		}

		private static double CountU1(double x, double u1, double u2)
		{
			return (2.0 * x / u1 + u2 / Math.Exp(x));
		}

		private static double CountU2(double x, double u1, double u2)
		{
			return (u1 * Math.Exp(x) / (2 * x));
		}

		private static double Fun1(double x)
		{
			return 2.0 * x;
		}

		private static double Fun2(double x)
		{
			return Math.Exp(x);
		}

		private static void CountFun(double[] mas1, double[] mas2, double[] x, int n)
		{
			for (var i = 0; i < n; i++)
			{
				mas1[i] = Fun1(x[i]);
				mas2[i] = Fun2(x[i]);
			}
		}

		private static void CountValues(double[] u1, double[] u2, double[] x, int n, double h)
		{
			var k21 = new double[n];
			var k22 = new double[n];
			var k1 = new double[n];
			var s21 = new double[n];
			var s22 = new double[n];
			var s1 = new double[n];
			for (var i = 1; i < n; i++)
			{
				double x12 = (x[i] + x[i - 1]) / 2.0;
				// Вычисление предиктора
				k21[i] = u1[i - 1] + h / 2.0 * CountU1(x[i - 1], u1[i - 1], u2[i - 1]);
				s21[i] = u2[i - 1] + h / 2.0 * CountU2(x[i - 1], u1[i - 1], u2[i - 1]);
				k22[i] = u1[i - 1] + h / 2.0 * CountU1(x12, k21[i], s21[i]);
				s22[i] = u2[i - 1] + h / 2.0 * CountU2(x12, k21[i], s21[i]);
				k1[i] = u1[i - 1] + h * CountU1(x12, k22[i], s22[i]);
				s1[i] = u2[i - 1] + h * CountU2(x12, k22[i], s22[i]);
				// Вычисление корректора
				u1[i] = u1[i - 1] + h / 6.0 * (CountU1(x[i - 1], u1[i - 1], u2[i - 1]) + 2.0 * CountU1(x12, k21[i], s21[i]) + 2.0 * CountU1(x12, k22[i], s22[i]) + CountU1(x[i], k1[i], s1[i]));
				u2[i] = u2[i - 1] + h / 6.0 * (CountU2(x[i - 1], u1[i - 1], u2[i - 1]) + 2.0 * CountU2(x12, k21[i], s21[i]) + 2.0 * CountU2(x12, k22[i], s22[i]) + CountU2(x[i], k1[i], s1[i]));
			}
		}
	}
}
