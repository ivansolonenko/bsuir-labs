using Labs.Shared.Cryptography.Interfaces;

namespace Labs.Shared.Cryptography.EncryptionMethods
{
	public class RailwayFenceMethod : IEncryptionMethod
	{
		private readonly int _key;

		public RailwayFenceMethod(int key)
		{
			_key = key;
		}

		public string Encrypt(string input)
		{
			if (_key <= 1)
				return input;

			var strings = new string[_key];
			for (var j = 0; j < _key; j++)
				strings[j] = string.Empty;

			var result = string.Empty;
			var n = input.Length;

			for (var i = 0; i < _key - 1; i++)
			{
				switch (i)
				{
					case 0:
						{
							for (var j = i; j < n; j += (2 * (_key) - 2))
							{
								strings[i] += input[j];
								if (j + _key - 1 < n)
									strings[_key - 1] += input.Substring(j + _key - 1, 1);
							}
						}
						break;

					default:
						{
							for (var j = i; j < n; j += (2 * (_key) - 2))
							{
								strings[i] += input[j];
								if (j + 2 * (_key - i - 1) < n)
									strings[i] += input.Substring(j + 2 * (_key - i - 1), 1);
							}
						}
						break;
				}
			}

			for (var j = 0; j < _key; j++)
				result += strings[j];

			return result;
		}

		public string Decrypt(string input)
		{
			string result = "";
			int blockLength = 2 * _key - 2;
			int nBlocks = input.Length / blockLength;
			int lastBlockLength = input.Length - nBlocks * blockLength;
			var strings = new string[_key];
			int flag = 0;

			var array = new int[_key];
			int num = 0;
			var test = new int[_key];

			for (int i = 0; i < lastBlockLength; i++)
			{
				array[num]++;
				if (i >= _key - 1)
					num--;
				else
					num++;
			}
			for (int i = 0; i < _key; i++)
			{
				if (i == 0 || i == _key - 1)
				{
					strings[i] = input.Substring(flag, nBlocks + array[i]);
					flag += nBlocks + array[i];
					test[i] = nBlocks + array[i];
				}
				else
				{
					strings[i] = input.Substring(flag, 2 * nBlocks + array[i]);
					flag += 2 * nBlocks + array[i];
					test[i] = 2 * nBlocks + array[i];
				}
			}

			int numString = 0;
			bool up = false;
			// int last = 0;
			int idx, idxTop = idx = 0;

			for (int i = 0; i < input.Length; i++)
			{
				if (numString == 0 || numString == _key - 1)
				{
					result += strings[numString][idxTop];
					if (numString == _key - 1)
					{
						idxTop++;
						up = true;
						idx++;
					}
				}
				else
				{
					result += strings[numString][idx];
				}
				if (!up)
					numString++;
				else
					numString--;
				if (numString == 0)
				{
					up = false;
					idx++;
				}
			}

			return result;
		}
	}
}
