using System;
using Labs.Shared.Cryptography.Interfaces;

namespace Labs.Shared.Cryptography.EncryptionMethods
{
	public class GridMethod : IEncryptionMethod
	{
		private const string DopStr = "_aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

		private readonly int _max;
		private bool[][] _boolChecked;

		public GridMethod(int max, bool[][] boolChecked)
		{
			_max = max;
			_boolChecked = boolChecked;
		}

		public string Encrypt(string input)
		{
			string result = string.Empty;
			var quadr = (int)Math.Pow(_max, 2);
			var size = (int)Math.Ceiling((double)input.Length / quadr);
			if (input.Length % quadr != 0)
			{
				input += DopStr.Substring(0, size * quadr - input.Length);
			}
			char[] text = input.ToCharArray();
			var massLetters = new char[_max][];
			for (var i = 0; i < _max; i++)
			{
				massLetters[i] = new char[_max];
			}
			int current = 0;
			bool center = _max % 2 != 0;
			int centerIndex = _max / 2;
			if (!center)
			{
				centerIndex = -1;
			}
			for (var k = 0; k < size; k++)
			{
				bool isWritten = false;
				for (var step = 0; step < 4; step++)
				{
					for (var i = 0; i < _max; i++)
					{
						for (var j = 0; j < _max; j++)
						{
							if (_boolChecked[i][j])
							{
								if (i != j)
								{
									massLetters[i][j] = text[current];
									current++;
								}
								else if (i != centerIndex)
								{
									massLetters[i][j] = text[current];
									current++;
								}
								else if (!isWritten)
								{
									massLetters[i][j] = text[current];
									current++;
									isWritten = true;
								}
							}
						}
					}
					_boolChecked = RotateGrid(_boolChecked, _max);
				}
				for (var m = 0; m < _max; m++)
				{
					result += new string(massLetters[m]);
				}
			}
			return result;
		}

		public string Decrypt(string input)
		{
			string result = string.Empty;
			var quadr = (int)Math.Pow(_max, 2);
			var size = (int)Math.Ceiling((double)input.Length / quadr);
			var massLetters = new char[_max][];
			for (var i = 0; i < _max; i++)
			{
				massLetters[i] = new char[_max];
			}
			int current = 0;
			bool center = _max % 2 != 0;
			int centerIndex = _max / 2;
			if (!center)
			{
				centerIndex = -1;
			}
			for (var k = 0; k < size; k++)
			{
				for (var step = 0; step < _max; step++)
				{
					massLetters[step] = input.Substring(current * quadr + _max * step, _max).ToCharArray();
				}
				current++;
				bool isWritten = false;
				for (var m = 0; m < 4; m++)
				{
					for (var i = 0; i < _max; i++)
					{
						for (var j = 0; j < _max; j++)
						{
							//if (_boolChecked[i][j])
							//{
							//  result += massLetters[i][j];
							//}
							if (_boolChecked[i][j])
							{
								if (i != j)
								{
									result += massLetters[i][j];
								}
								else if (i != centerIndex)
								{
									result += massLetters[i][j];
								}
								else if (!isWritten)
								{
									result += massLetters[i][j];
									isWritten = true;
								}
							}
						}
					}
					_boolChecked = RotateGrid(_boolChecked, _max);
				}
			}
			result = result.Substring(0, result.LastIndexOf('_'));
			return result;
		}

		private static bool[][] RotateGrid(bool[][] mass, int max)
		{
			var newSelectedIndexesMatrix = new bool[max][];

			for (var i = 0; i < max; i++)
			{
				newSelectedIndexesMatrix[i] = new bool[max];
			}

			for (var i = 0; i < max; i++)
			{
				for (var j = 0; j < max; j++)
				{
					if (mass[i][j])
					{
						newSelectedIndexesMatrix[j][max - i - 1] = true;
					}
				}
			}

			return newSelectedIndexesMatrix;
		}
	}
}
