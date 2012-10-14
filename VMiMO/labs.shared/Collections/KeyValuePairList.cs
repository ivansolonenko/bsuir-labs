using System.Collections.Generic;

namespace labs.Collections
{
	public class KeyValuePairList<TKey, TValue> : List<KeyValuePair<TKey, TValue>>
	{
		public void Add(TKey key, TValue value)
		{
			Add(new KeyValuePair<TKey, TValue>(key, value));
		}
	}
}
