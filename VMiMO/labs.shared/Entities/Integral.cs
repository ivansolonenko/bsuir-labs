namespace labs.Entities
{
	public class Integral
	{
		public delegate double LambdaExpression(double value);
		public LambdaExpression Function { get; set; }
		public LambdaExpression FirstDerivative { get; set; }
		public LambdaExpression SecondDerivative { get; set; }

		public double A { get; set; }
		public double B { get; set; }
		public double N { get; set; }

		public double H { get; set; }
		public double K { get; set; }
	}
}
