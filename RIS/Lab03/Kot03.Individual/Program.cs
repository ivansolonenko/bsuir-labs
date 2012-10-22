using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Kot03.Individual
{
	static class Program
	{
		private const string File1 = @"..\..\..\..\file1.txt";
		private const string File2 = @"..\..\..\..\file2.txt";
		private const string File3 = @"..\..\..\..\file3.txt";

		static void Main(string[] args)
		{
			int tokenLength;
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

			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("Original Text: {0}", originalText);

			Console.WriteLine(Environment.NewLine);
			Console.Write("Enter token length: ");
			if (!int.TryParse(Console.ReadLine(), out tokenLength))
			{
				Console.WriteLine("Not a number");
				return;
			}

			var modifiedText = Regex.Replace(originalText,
				string.Format(@"\b[bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ]{{1}}\w{{{0}}}\b", tokenLength - 1), "");

			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("Modified Text: {0}", modifiedText);

			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("Writing file2.txt");
			using (var sr = new StreamWriter(File2))
			{
				sr.Write(modifiedText);
			}

			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("Writing file3.txt");
			using (var sr = new StreamWriter(File3))
			{
				sr.WriteLine(originalText);
				sr.Write(Environment.NewLine);
				sr.Write(modifiedText);
			}
		}
	}
}
