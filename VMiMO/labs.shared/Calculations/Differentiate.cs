using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using labs.Entities;
using labs.Helpers;

namespace labs.Calculations
{
	public static partial class Calculations
	{
		private static IEnumerable<Tuple<double, double, double, double>> DifferentiateFirst(this Integral integral, int count)
		{
			for (var i = 0; i <= count; i++)
			{
				var x = integral.A + i * (integral.B - integral.A) / 10;
				var value = integral.FirstDerivative(x);
				var approximation = (integral.Function(x + integral.H) - integral.Function(x - integral.H)) / (2 * integral.H);
				var error = (value - approximation) * integral.K;

				yield return new Tuple<double, double, double, double>(x, value, approximation, error);
			}
		}

		private static IEnumerable<Tuple<double, double, double, double>> DifferentiateSecond(this Integral integral, int count)
		{
			for (var i = 0; i <= count; i++)
			{
				var x = integral.A + i * (integral.B - integral.A) / 10;
				var value = integral.SecondDerivative(x);
				var approximation = (integral.Function(x + integral.H) - 2 * integral.Function(x) + integral.Function(x - integral.H)) / Math.Pow(integral.H, 2);
				var error = (value - approximation) * integral.K;

				yield return new Tuple<double, double, double, double>(x, value, approximation, error);
			}
		}

		// TODO: Reimplement
		// ReSharper disable UnusedParameter.Global
		public static IEnumerable Differentiate(this Integral integral, int level, int count, PrettyPrint value)
		// ReSharper restore UnusedParameter.Global
		{
			IEnumerable<Tuple<double, double, double, double>> result;
			switch (level)
			{
				case 1:
					result = integral.DifferentiateFirst(count);
					break;

				case 2:
					result = integral.DifferentiateSecond(count);
					break;

				default:
					result = new Tuple<double, double, double, double>[0];
					break;
			}

			var sb = new StringBuilder();
			sb.AppendFormat("{1,-3}{2,15}\t{3,15}\t{4,20}{0}", Environment.NewLine, "Xj", "Точное", "Приближенное", "Погрешность");
			foreach (var tuple in result)
				sb.AppendFormat("{1,-3}{2,15}\t{3,15}\t{4,13} * 10^4{0}", Environment.NewLine, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);

			return sb.ToString();
		}
	}
}
