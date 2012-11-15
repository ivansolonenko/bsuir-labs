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
		private static double[] Intervals(this Interval interval)
		{
			var count = 0;
			var tmp = new double[100];

			tmp[count++] = interval.A;
			for (var x = interval.A; x < interval.B; x += interval.Inc)
				if (interval.Df(x) * interval.Df(x + interval.Inc) <= 0 && Math.Abs(x - tmp[count - 1]) > interval.Inc)
					tmp[count++] = x;

			tmp[count++] = interval.B;
			var intervals = new double[count];
			for (var i = 0; i < count; ++i)
				intervals[i] = tmp[i];

			return intervals;
		}

		private static double Near(this Interval interval, double x)
		{
			double x1;
			do
			{
				x1 = x;
				x = x - interval.Function.Value(x) * interval.Eps / (interval.Function.Value(x + interval.Eps) - interval.Function.Value(x));
			} while (Math.Abs(x1 - x) > interval.Eps);
			return x;
		}

		private static IEnumerable<double> Roots(this Interval interval)
		{
			var intervals = interval.Intervals();
			for (var i = 0; i < intervals.Length - 1; ++i)
				yield return interval.Near((intervals[i] + intervals[i + 1]) / 2);
		}

		public static string Roots(this Interval interval, PrettyPrint value)
		{
			var result = interval.Roots();

			var sb = new StringBuilder();
			for (var i = 1; i <= result.Count(); i++)
				sb.AppendFormat("x{0} = {1}" + Environment.NewLine, i, result.ElementAt(i - 1));

			return sb.ToString();
		}
	}
}
