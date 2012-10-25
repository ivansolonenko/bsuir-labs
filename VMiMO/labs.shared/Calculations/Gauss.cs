using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using labs.Entities;
using labs.Helpers;

namespace labs.Calculations
{
	public static partial class Calculations
	{
		private static ICollection<double> Gauss(this EquationSystem system)
		{
			var a = system.Coefficients.ToArray();
			var b = system.Values.ToArray();
			var n = a.Length;
			var x = new double[n];

			for (int k = 0; k < n; k++)
			{
				int p = k;
				for (int m = k + 1; m < n; m++)
					if (Math.Abs(a[m, k]) > Math.Abs(a[p, k]))
						p = m;

				for (int j = k; j < n; j++)
				{
					double w = a[k, j];
					a[k, j] = a[p, j];
					a[p, j] = w;
				}

				{
					double w = b[k];
					b[k] = b[p];
					b[p] = w;
				}

				for (int m = k + 1; m < n; m++)
				{
					double w = a[m, k] / a[k, k];
					b[m] = b[m] - w * b[k];

					for (int i = k; i < n; i++)
						a[m, i] = a[m, i] - w * a[k, i];
				}
			}

			x[n - 1] = b[n - 1] / a[n - 1, n - 1];

			for (int k = n - 1; k > -1; k--)
			{
				var s = 0.0;
				for (int i = k + 1; i < n; i++)
					s += a[k, i] * x[i];
				x[k] = (b[k] - s) / a[k, k];
			}

			return x;
		}

		// TODO: Reimplement
		// ReSharper disable UnusedParameter.Global
		public static string Gauss(this EquationSystem system, PrettyPrint value)
		// ReSharper restore UnusedParameter.Global
		{
			var result = system.Gauss();

			var sb = new StringBuilder();
			for (var i = 1; i <= result.Count; i++)
				sb.AppendFormat(i == result.Count ? "x{0}={1:f}." : "x{0}={1:f}; ", i, result.ElementAt(i - 1));

			return sb.ToString();
		}
	}
}
