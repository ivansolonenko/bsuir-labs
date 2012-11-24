using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Lab04.Server
{
	public static class ThreadClass
	{
		private const String FileName = @"C:\Users\Public\Documents\treeStorage.txt";
		private static NetworkStream _networkStream;

		public static void ThreadOperations(object clientObj)
		{
			var client = clientObj as TcpClient;
			if (client == null)
				return;
			_networkStream = client.GetStream();

			//функции начинается с чтения запроса из потока:
			//Создаем новую переменную типа byte[]
			var received = new byte[256];
			//С помощью сетевого потока считываем в переменную received данные от клиента
			_networkStream.Read(received, 0, received.Length);

			var str = Encoding.UTF8.GetString(received);
			var cmd = str.Substring(0, str.IndexOf('|'));
			var val = str.Substring(str.IndexOf('|') + 1, str.IndexOf('\0'));

			if (cmd == "view")
			{
				// Создаем переменную типа byte[] для отправки ответа клиенту
				//Создаем объект класса FileStream для последующего чтения информации из файла
				var fstr = new FileStream(FileName, FileMode.Open, FileAccess.Read);
				var sr = new StreamReader(fstr);
				//Запись в переменную sent содержания прочитанного файла
				byte[] sent = Encoding.UTF8.GetBytes(sr.ReadToEnd());
				sr.Close();
				fstr.Close();
				//Отправка информации клиенту
				_networkStream.Write(sent, 0, sent.Length);
			}
			else if (cmd == "add")
			{
				var fstr = new FileStream(FileName, FileMode.Append, FileAccess.Write);
				var sr = new StreamWriter(fstr);
				sr.Write(val);
				byte[] sent = Encoding.UTF8.GetBytes(val);
				sr.Close();
				fstr.Close();
				_networkStream.Write(sent, 0, sent.Length);
			}
		}
	}
}
