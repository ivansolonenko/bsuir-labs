// ReSharper disable UnusedParameter.Local
// ReSharper disable CompareOfFloatsByEqualityOperator
using System;

namespace lab02
{
	static class Program
	{
		const int A = -2;
		const int B = 3;
		const int M = 11;

		static void Main(string[] args)
		{
			int i, j, k;
			var sums = new double[5, 5];
			var x = new double[20];
			var y = new double[20];
			var f = new double[20];
			var d = new double[20];
			var b = new double[10];
			var a = new double[10];

			//Заполняем массивы значениями
			for (i = 0; i < 11; i++)
			{
				x[i] = A + (double)i * (B - A) / (M - 1);
				y[i] = 4 * x[i] - 7 * Math.Sin(x[i]);
				//y[i] = 1 + 2 * x[i] + 3 * Math.Pow(x[i], 2);
			}

			//вычисляем квадратные суммы матрицы
			for (i = 0; i < 4; i++)
			{
				for (j = 0; j < 4; j++)
				{
					sums[i, j] = 0;
					for (k = 0; k < 11; k++)
						sums[i, j] += Math.Pow(x[k], (i + j));
				}
			}

			//вычисляем свободные коэффициенты
			for (i = 0; i < 4; i++)
				for (k = 0; k < 11; k++)
					b[i] += Math.Pow(x[k], i) * y[k];

			//находим коэффициенты
			for (k = 0; k < 4; k++)
			{
				for (i = k + 1; i < 4; i++)
				{
					if (sums[k, k] == 0)
					{
						Console.WriteLine("Решения не существует.");
						return;
					}
					double m = sums[i, k] / sums[k, k];
					for (j = k; j < 4; j++)
						sums[i, j] -= m * sums[k, j];
					b[i] -= m * b[k];
				}
			}

			for (i = (4) - 1; i >= 0; i--)
			{
				double s = 0;
				for (j = i; j < 4; j++)
					s = s + sums[i, j] * a[j];
				a[i] = (b[i] - s) / sums[i, i];
			}

			for (i = 0; i < 4; i++)
				Console.WriteLine("a[{0}] = {1:0.0000}", i, a[i]);

			Console.WriteLine("\nФункция имеет вид: y = {0:0.0000} + {1:0.0000}x + {2:0.0000}x^2 + {3:0.0000}x^3\n", a[0], a[1], a[2], a[3]);

			for (i = 0; i < 20; i++)
			{
				x[i] = A + (double)(i + 1) * (B - A) / 20;
				y[i] = 4 * x[i] - 7 * Math.Sin(x[i]);
				//y[i] = 1 + 2 * x[i] + 3 * Math.Pow(x[i], 2);
				f[i] = a[0] + a[1] * x[i] + a[2] * x[i] * x[i] + a[3] * x[i] * x[i] * x[i];
				d[i] = y[i] - f[i];
				Console.WriteLine("y(x) = {0:0.0000}\tf(x) = {1:0.0000}\td = {2:0.0000}", y[i], f[i], d[i]);
			}
		}
	}
}
// ReSharper restore CompareOfFloatsByEqualityOperator
// ReSharper restore UnusedParameter.Local
