/* Usage:

	var approximation = new Approximation
		{
			A = 3,
			B = 6,
			M = 11,
			N = 3,
			Function = x => Math.Log(x) - 5 * Math.Pow(Math.Sin(x), 2)
		};

*/

using System;
using System.Collections.Generic;

namespace labs.Entities
{
	public class Approximation
	{
		public MathematicalFunction Function { private get; set; }

		public int A { private get; set; }
		public int B { private get; set; }
		public int M { private get; set; }
		public int N { private get; set; }

		private List<Tuple<double, double>> _values;
		public List<Tuple<double, double>> Values
		{
			get
			{
				if (_values != null)
					return _values;

				_values = new List<Tuple<double, double>>();

				for (var i = 1; i <= M; i++)
				{
					var x = A + (i - 1) * (B - A) / (M - 1);
					var y = Function.Value(x);
					_values.Add(new Tuple<double, double>(x, y));
				}

				return _values;
			}
		}
	}
}
