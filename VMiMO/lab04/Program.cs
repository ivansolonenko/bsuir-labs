using System;
using labs.Collections;
using labs.Helpers;

namespace lab04
{
	static class Program
	{
		// ReSharper disable UnusedParameter.Local
		static void Main(string[] args)
		// ReSharper restore UnusedParameter.Local
		{
			try
			{
				const double e = 0.0000001;

				Console.WriteLine("Введите размерность матрицы:");
				var n = Helpers.StringToNumber<int>(Console.ReadLine());

				Console.WriteLine("Введите матрицу коэфициентов:");
				var collection = new TwoDimensionalCollection<double>();

				for (var i = 0; i < n; i++)
					collection.Add(Helpers.StringToEnumerable<double>(Console.ReadLine(), n));

				var arrays = collection.ToArray();

				var x = new double[n];
				for (var i = 0; i < n; i++)
					x[i] = 1;

				var l = new double[n];
				for (var i = 0; i < n; i++)
					l[i] = 0;

				double[] oX;
				double max;

				do
				{
					oX = x;
					x = new double[n];
					var oL = l;
					max = 0;
					l = new double[n];
					for (var i = 0; i < n; i++)
					{
						x[i] = 0;
						for (var j = 0; j < n; j++)
							x[i] += arrays[i, j] * oX[j];

						l[i] = x[i] / oX[i];

						var cur = Math.Abs((l[i] - oL[i]) / l[i]);
						if (cur > max)
							max = cur;
					}
				} while (max > e);
				oX = x;
				x = new double[n];

				for (var i = 0; i < n; i++)
					x[i] = oX[i] / oX[0];

				for (var i = 0; i < n; i++)
					if (l[i] > max)
						max = l[i];

				Console.WriteLine("Максимальное собственное значение: {0}", max);
			}
			catch (ApplicationException ex)
			{
				Console.WriteLine("Ошибка: {0}", ex.Message);
			}
		}
	}
}
