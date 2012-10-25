using System.Collections.Generic;
using System.Linq;

namespace labs.Collections
{
	public class TwoDimensionalCollection<T>
	{
		private readonly ICollection<IEnumerable<T>> _collection = new List<IEnumerable<T>>();

		public void Add(IEnumerable<T> row)
		{
			_collection.Add(row);
		}

		public T[,] ToArray()
		{
			var count = _collection.Count;
			var result = new T[count, count];

			for (var i = 0; i < count; i++)
				for (var j = 0; j < count; j++)
					result[i, j] = _collection.ElementAt(i).ElementAt(j);

			return result;
		}

		public T[][] ToArrays()
		{
			return _collection.Select(c => c.ToArray()).ToArray();
		}
	}
}
