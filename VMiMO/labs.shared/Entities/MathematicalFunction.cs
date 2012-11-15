namespace labs.Entities
{
	public class MathematicalFunction
	{
		public delegate double MathematicalFunctionDelegate(double value);
		public MathematicalFunctionDelegate Value { get; set; }
	}
}
