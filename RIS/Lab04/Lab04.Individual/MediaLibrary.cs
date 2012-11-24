using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace Lab04.Individual
{
	public class MediaLibrary
	{
		private const int MessageLength = 1024;

		private static TcpClient TcpClient
		{
			get { return new TcpClient("localhost", 5555); }
		}

		private ICollection<dynamic> _tracks;

		public ICollection<dynamic> Tracks
		{
			get { return _tracks ?? (_tracks = Perform("view")); }
		}

		public void Add(string artist, string album, string track)
		{
			var obj = new { Artist = artist, Album = album, Track = track };
			Perform("add", obj);
			_tracks = null;
		}

		public void Filter(string artist)
		{
			var obj = new { Artist = artist };
			var filtered = Perform("filter", obj);
			_tracks = filtered;
		}

		public void FilterMaxAlbums()
		{
			var filtered = Perform("filterMaxAlbums");
			_tracks = filtered;
		}

		public void Reset()
		{
			_tracks = null;
		}

		private static dynamic Perform(string command, dynamic obj = null)
		{
			var ns = TcpClient.GetStream();
			var request = string.Format("{0}|{1}", command, JsonConvert.SerializeObject(obj));
			var sent = Encoding.UTF8.GetBytes(request);
			ns.Write(sent, 0, sent.Length);
			// Waiting...
			var recieved = new byte[MessageLength];
			ns.Read(recieved, 0, recieved.Length);
			var response = Encoding.UTF8.GetString(recieved).Trim('\0');

			return JsonConvert.DeserializeObject<List<dynamic>>(response);
		}
	}
}
