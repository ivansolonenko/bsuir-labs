using Labs.Shared.Cryptography.Interfaces;

namespace Labs.Shared.Cryptography.EncryptionMethods
{
	public class CaesarMethod : IEncryptionMethod
	{
		private readonly int _value;
		private readonly int _nvalue;

		public CaesarMethod(int value, int nvalue)
		{
			_value = value;
			_nvalue = nvalue;
		}

		public string Encrypt(string input)
		{
			char[] buf = input.ToCharArray();

			for (int i = 0; i < buf.Length; i++)
			{
				buf[i] = (char)((buf[i] + _value) % _nvalue);
			}

			return new string(buf);
		}

		public string Decrypt(string input)
		{
			char[] buf = input.ToCharArray();

			for (int i = 0; i < buf.Length; i++)
			{
				buf[i] = (char)((buf[i] - _value) % _nvalue);
			}

			return new string(buf);
		}
	}
}
