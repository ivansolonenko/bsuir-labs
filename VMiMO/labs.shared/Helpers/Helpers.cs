using System;
using System.Collections.Generic;

namespace labs.Helpers
{
	public static class Helpers
	{
		public static T StringToNumber<T>(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
				throw new ApplicationException("Введена пустая строка.");

			T count;
			if (!TryParse(input, out count))
				throw new ApplicationException("Введено не число.");

			return count;
		}

		public static IEnumerable<T> StringToEnumerable<T>(string input, int count)
		{
			var tokens = input.Split(new[] { ' ' });

			if (count < tokens.Length)
				throw new ApplicationException("Введено меньше чисел чем задано.");
			if (count > tokens.Length)
				throw new ApplicationException("Введено больше чисел чем задано.");

			foreach (var token in tokens)
			{
				T x;
				if (TryParse(token, out x))
					yield return x;
			}
		}

		private static bool TryParse<T>(string text, out T value)
		{
			value = default(T);
			try
			{
				value = (T)Convert.ChangeType(text, typeof(T));
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
