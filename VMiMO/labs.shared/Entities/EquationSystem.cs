using System.Collections.Generic;
using labs.Collections;

namespace labs.Entities
{
	public class EquationSystem
	{
		public TwoDimensionalCollection<double> Coefficients { get; private set; }
		public IEnumerable<double> Values { get; set; }
	}
}
