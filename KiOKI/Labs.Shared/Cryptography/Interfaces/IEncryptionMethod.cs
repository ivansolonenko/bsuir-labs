namespace Labs.Shared.Cryptography.Interfaces
{
	public interface IEncryptionMethod
	{
		string Encrypt(string input);
		string Decrypt(string input);
	}
}
