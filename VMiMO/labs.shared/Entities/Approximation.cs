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

using labs.Collections;

namespace labs.Entities
{
	public class Approximation
	{
		public delegate double MyFunc(double value);
		public MyFunc Function { private get; set; }

		public int A { private get; set; }
		public int B { private get; set; }
		public int M { private get; set; }
		public int N { private get; set; }

		private KeyValuePairList<double, double> _values;
		public KeyValuePairList<double, double> Values
		{
			get
			{
				if (_values != null)
					return _values;

				_values = new KeyValuePairList<double, double>();

				for (var i = 1; i <= M; i++)
				{
					var x = A + (i - 1) * (B - A) / (M - 1);
					var y = Function(x);
					_values.Add(x, y);
				}

				return _values;
			}
		}
	}
}
