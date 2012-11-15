namespace labs.Entities
{
	public class Integral
	{
		public MathematicalFunction Function { get; set; }
		public MathematicalFunction FirstDerivative { get; set; }
		public MathematicalFunction SecondDerivative { get; set; }

		public double A { get; set; }
		public double B { get; set; }
		public double N { get; set; }

		public double H { get; set; }
		public double K { get; set; }
	}
}
