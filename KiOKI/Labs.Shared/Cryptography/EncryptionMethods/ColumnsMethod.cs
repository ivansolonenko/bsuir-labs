using System;
using System.Globalization;
using Labs.Shared.Cryptography.Interfaces;
using Labs.Shared.Cryptography.Models;

namespace Labs.Shared.Cryptography.EncryptionMethods
{
	public class ColumnsMethod : IEncryptionMethod
	{
		private readonly string _key;

		public ColumnsMethod(string key)
		{
			_key = key;
		}

		public string Encrypt(string input)
		{
			var result = string.Empty;

			var keyPhrase = new KeyPhrase[_key.Length];
			for (int i = 0; i < keyPhrase.Length; i++)
			{
				keyPhrase[i] = new KeyPhrase { Num = _key[i] };
			}

			int idx = 0;
			int k = 0;

			while (idx < input.Length)
			{
				keyPhrase[k].Column += input[idx].ToString(CultureInfo.InvariantCulture);
				idx++;
				k++;
				if (k == keyPhrase.Length)
					k = 0;
			}

			BubbleSort(keyPhrase);

			for (int i = 0; i < keyPhrase.Length; i++)
			{
				result += keyPhrase[i].Column;
			}

			return result;
		}

		public string Decrypt(string input)
		{
			var result = string.Empty;

			var keyPhrase = new KeyPhrase[_key.Length];
			for (int i = 0; i < keyPhrase.Length; i++)
			{
				keyPhrase[i] = new KeyPhrase { Position = i, Num = _key[i] };
			}

			int nSymbols = input.Length / _key.Length;
			int symbolsLeft = input.Length - nSymbols * _key.Length;
			for (int i = 0; symbolsLeft > 0; i++)
			{
				keyPhrase[i].Symbol++;
				symbolsLeft--;
			}
			BubbleSort(keyPhrase);
			int flag = 0;
			for (int i = 0; i < keyPhrase.Length; i++)
			{
				keyPhrase[i].Column = input.Substring(flag, nSymbols + keyPhrase[i].Symbol);
				flag += nSymbols + keyPhrase[i].Symbol;
			}

			Array.Sort(keyPhrase);

			int num = 0;
			int idx = 0;
			for (int i = 0; i < input.Length; i++)
			{
				result += keyPhrase[num].Column[idx].ToString(CultureInfo.InvariantCulture);
				num++;
				if (num == _key.Length)
				{
					num = 0;
					idx++;
				}
			}

			return result;
		}

		private static void BubbleSort(KeyPhrase[] keyPhrases)
		{
			int i, j;
			for (j = 0; j < keyPhrases.Length; j++)
				for (i = 0; i < keyPhrases.Length - 1; i++)
					if (keyPhrases[i].Num > keyPhrases[i + 1].Num)
					{
						Swap(i, i + 1, keyPhrases);
					}
		}

		private static void Swap(int x, int y, KeyPhrase[] keyPhrases)
		{
			KeyPhrase tmp = keyPhrases[x];
			keyPhrases[x] = keyPhrases[y];
			keyPhrases[y] = tmp;
		}
	}
}
