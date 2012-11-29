using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Lab04.Server
{
	public static class MediaLibraryClass
	{
		private const String Filename = @"C:\Users\Public\Documents\mediaStorage.txt";
		private const int MessageLength = 1024;

		public static void ThreadOperations(object clientObj)
		{
			var client = clientObj as TcpClient;
			if (client == null)
				return;
			var ns = client.GetStream();

			var received = new byte[MessageLength];
			ns.Read(received, 0, received.Length);

			var request = Encoding.UTF8.GetString(received).Trim('\0');
			var cmd = request.Substring(0, request.IndexOf('|'));
			var val = request.Substring(request.IndexOf('|') + 1);

			var storage = new Storage<dynamic> { Filename = Filename };

			switch (cmd)
			{
				case "view":
					{
						var bytes = storage.View();
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
				case "add":
					{
						var bytes = storage.Add(val, (objects, o) =>
												{
													int id = objects.Count > 0 ? objects.ElementAt(objects.Count - 1).Id : 0;
													o.Id = ++id;
												});
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
				case "filter":
					{
						var bytes = storage.Filter(val, (objects, o) => objects.Where(x => x.Artist == o.Artist));
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
				case "filterMaxAlbums":
					{
						var bytes = storage.Filter(objects =>
																				{
																					var maxAlbums = 0;
																					var maxArtist = string.Empty;
																					var grouped = objects.GroupBy(x => x.Artist);
																					foreach (var grouping in grouped)
																					{
																						var count = grouping.Select(x => x.Album).Count();
																						if (count <= maxAlbums) continue;
																						maxAlbums = count;
																						maxArtist = grouping.Key;
																					}
																					return maxArtist;
																				},
																				(objects, o) => objects.Where(x => x.Artist == o));
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
			}

			ns.Close();
			client.Close();
		}
	}
}
