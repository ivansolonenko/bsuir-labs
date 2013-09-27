using Labs.Shared.Cryptography.Interfaces;

namespace Labs.Shared.Cryptography.EncryptionMethods
{
	public class CaesarMethod : IEncryptionMethod
	{
		private readonly int _k;
		private readonly int _n;

		public CaesarMethod(int k, int n)
		{
			_k = k;
			_n = n;
		}

		public string Encrypt(string input)
		{
			char[] buf = input.ToCharArray();

			for (int i = 0; i < buf.Length; i++)
			{
				buf[i] = (char)((buf[i] + _k) % _n);
			}

			return new string(buf);
		}

		public string Decrypt(string input)
		{
			char[] buf = input.ToCharArray();

			for (int i = 0; i < buf.Length; i++)
			{
				buf[i] = (char)((buf[i] - _k) % _n);
			}

			return new string(buf);
		}
	}
}
