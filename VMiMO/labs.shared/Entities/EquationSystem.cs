using System.Collections.Generic;

namespace labs.Entities
{
	public class EquationSystem
	{
		public ICollection<IEnumerable<double>> Coefficients { get; private set; }
		public IEnumerable<double> Values { get; set; }

		public EquationSystem()
		{
			Coefficients = new List<IEnumerable<double>>();
		}
	}
}
