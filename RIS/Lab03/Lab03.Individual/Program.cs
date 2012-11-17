using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab03.Individual
{
	static class Program
	{
		private const string File1 = @"C:\Users\Public\Documents\file1.txt";
		private const string File2 = @"C:\Users\Public\Documents\file2.txt";
		private const string File3 = @"C:\Users\Public\Documents\file3.txt";

		private static readonly char[] Vowels = new[] { 'e', 'y', 'u', 'i', 'o', 'a' };

		static void Main(string[] args)
		{
			string originalText;

			if (!File.Exists(File1))
			{
				Console.WriteLine("No file file1.txt");
				return;
			}

			Console.WriteLine("Reading file1.txt");
			using (var sr = new StreamReader(File1))
			{
				originalText = sr.ReadToEnd();
			}

			int totalCount = 0, spacesCount = 0, vowelsCount = 0;

			foreach (var x in originalText.ToCharArray())
			{
				totalCount++;
				if (x == ' ')
					spacesCount++;
				else if (Vowels.Contains(x))
					vowelsCount++;
			}

			var result = new StringBuilder()
				.AppendFormat("Total symbols count: {0}", totalCount)
				.Append(Environment.NewLine)
				.AppendFormat("Vowels count: {0}", vowelsCount)
				.Append(Environment.NewLine)
				.AppendFormat("Whitespaces count: {0}", spacesCount)
				.ToString();

			Console.WriteLine("Writing file2.txt");
			using (var sr = new StreamWriter(File2))
			{
				sr.Write(result);
			}

			Console.WriteLine("Writing file3.txt");
			using (var sr = new StreamWriter(File3))
			{
				sr.WriteLine(originalText);
				sr.Write(Environment.NewLine);
				sr.Write(result);
			}
		}
	}
}
