using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Lab04.Server
{
	public static class ThreadClass
	{
		private const String Filename = @"C:\Users\Public\Documents\treeStorage.txt";
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
				case "delete":
					{
						var bytes = storage.Delete(val, (objects, o) => objects.SingleOrDefault(x => x.Id == o.Id));
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
				case "edit":
					{
						var bytes = storage.Edit(val,
												(objects, o) => objects.SingleOrDefault(x => x.Id == o.Id),
												(x, y) => { x.District = y.District; x.Tree = y.Tree; x.Amount = y.Amount; });
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
				case "find":
					{
						var bytes = storage.Filter(val, (objects, o) => objects.Where(x => x.Amount == o.Amount));
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
				case "sort":
					{
						var bytes = storage.Filter(val, (objects, o) => objects.OrderByDescending(x => x.Amount));
						ns.Write(bytes, 0, bytes.Length);
					}
					break;
			}
		}
	}
}
