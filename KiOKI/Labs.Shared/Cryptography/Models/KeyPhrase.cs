using System;

namespace Labs.Shared.Cryptography.Models
{
	internal class KeyPhrase : IComparable
	{
		public char Num { get; set; }
		public string Column { get; set; }
		public int Symbol { get; set; }
		public int Position { get; set; }

		/// <summary>
		/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
		/// </summary>
		/// <param name="obj">An object to compare with this instance.</param>
		/// <returns>
		/// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has these meanings:
		/// Value
		/// Meaning
		/// Less than zero
		/// This instance is less than <paramref name="obj"/>.
		/// Zero
		/// This instance is equal to <paramref name="obj"/>.
		/// Greater than zero
		/// This instance is greater than <paramref name="obj"/>.
		/// </returns>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="obj"/> is not the same type as this instance.
		/// </exception>
		public int CompareTo(object obj)
		{
			var temp = (KeyPhrase)obj;
			if (Position > temp.Position)
				return 1;
			if (Position < temp.Position)
				return -1;
			else
				return 0;
		}
	}
}
