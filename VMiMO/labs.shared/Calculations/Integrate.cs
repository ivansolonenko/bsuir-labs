using labs.Entities;

namespace labs.Calculations
{
	public static partial class Calculations
	{
		public static double Integrate(this Integral integral)
		{
			double s = 0;

			var h = (double)(integral.B - integral.A) / integral.N;
			var x = integral.A + h / 2;

			for (int i = 0; i < integral.N; i++)
			{
				s += integral.Function(x);
				x = x + h;
			}
			s = s * h;

			return s;
		}
	}
}
