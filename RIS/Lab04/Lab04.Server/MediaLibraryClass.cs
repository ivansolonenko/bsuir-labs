using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace Lab04.Server
{
	public static class MediaLibraryClass
	{
		private const String FileName = @"C:\Users\Public\Documents\mediaStorage.txt";
		private const int MessageLength = 1024;

		public static void ThreadOperations(object clientObj)
		{
			var client = clientObj as TcpClient;
			if (client == null)
				return;

			var received = new byte[MessageLength];
			var ns = client.GetStream();

			ns.Read(received, 0, received.Length);
			var request = Encoding.UTF8.GetString(received).Trim('\0');
			var cmd = request.Substring(0, request.IndexOf('|'));
			var val = request.Substring(request.IndexOf('|') + 1);

			switch (cmd)
			{
				case "view":
					{
						var bytes = Encoding.UTF8.GetBytes(ReadRaw());
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
				case "add":
					{
						List<dynamic> data = Read();
						var obj = JsonConvert.DeserializeObject<dynamic>(val);
						data.Add(obj);
						Write(data);
						var bytes = Encoding.UTF8.GetBytes("[\"ok\"]");
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
				case "filter":
					{
						List<dynamic> data = Read();
						var obj = JsonConvert.DeserializeObject<dynamic>(val);
						var result = data.Where(x => x.Artist == obj.Artist);
						var str = JsonConvert.SerializeObject(result);
						var bytes = Encoding.UTF8.GetBytes(str);
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
				case "filterMaxAlbums":
					{
						List<dynamic> data = Read();
						var maxAlbums = 0;
						var maxArtist = string.Empty;
						var grouped = data.GroupBy(x => x.Artist);
						foreach (var grouping in grouped)
						{
							var count = grouping.Select(x => x.Album).Count();
							if (count <= maxAlbums) continue;
							maxAlbums = count;
							maxArtist = grouping.Key;
						}
						var result = data.Where(x => x.Artist == maxArtist);
						var str = JsonConvert.SerializeObject(result);
						var bytes = Encoding.UTF8.GetBytes(str);
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
			}

			ns.Close();
			client.Close();
		}

		private static dynamic Read()
		{
			using (var fs = File.Open(FileName, FileMode.Open))
			using (var sr = new StreamReader(fs))
			using (var jr = new JsonTextReader(sr))
				return new JsonSerializer().Deserialize<List<dynamic>>(jr) ?? new List<dynamic>();
		}

		private static string ReadRaw()
		{
			using (var fs = File.Open(FileName, FileMode.Open))
			using (var sr = new StreamReader(fs))
				return sr.ReadToEnd();
		}

		private static void Write(dynamic data)
		{
			using (var fs = File.Open(FileName, FileMode.Create))
			using (var sw = new StreamWriter(fs))
			using (var jw = new JsonTextWriter(sw))
				new JsonSerializer().Serialize(jw, data);
		}
	}
}
