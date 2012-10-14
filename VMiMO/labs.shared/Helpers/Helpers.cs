using System;
using System.Collections.Generic;

namespace labs.Helpers
{
	public static class Helpers
	{
		public static int StringToInt(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
				return 0;

			int count;
			return int.TryParse(input, out count) ? count : 0;
		}

		public static IEnumerable<double> StringToDoubleArrayWithCheck(string input, int count)
		{
			var tokens = input.Split(new[] { ' ' });

			if (count < tokens.Length)
				throw new ApplicationException("Введено меньше чисел чем задано.");
			if (count > tokens.Length)
				throw new ApplicationException("Введено больше чисел чем задано.");

			foreach (var token in tokens)
			{
				double x;
				if (double.TryParse(token, out x))
					yield return x;
			}
		}
	}
}
