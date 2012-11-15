namespace labs.Entities
{
	public class Interval
	{
		public MathematicalFunction Function { get; set; }

		public double A { get; set; }
		public double B { get; set; }
		public double Eps { get; set; }
		public double Inc { get; set; }

		public double Df(double x)
		{
			return (Function.Value(x + Eps) - Function.Value(x)) / Eps;
		}
	}
}
