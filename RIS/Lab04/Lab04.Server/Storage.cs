using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Lab04.Server
{
	internal class Storage<T> where T : class
	{
		private readonly string _error = JsonConvert.SerializeObject(new[] { "Error" });
		internal string Filename { private get; set; }

		internal byte[] View()
		{
			return Response(ReadRaw());
		}

		internal byte[] Add(string json, Action<ICollection<T>, T> action)
		{
			var data = Read();
			var obj = JsonConvert.DeserializeObject<T>(json);
			action(data, obj);
			data.Add(obj);
			Write(data);
			return Response(obj);
		}

		internal byte[] Delete(string json, Func<ICollection<T>, T, T> selector)
		{
			var data = Read();
			var obj = JsonConvert.DeserializeObject<T>(json);
			var item = selector(data, obj);
			if (item != null)
			{
				data.Remove(item);
				Write(data);
				return Response(item);
			}
			return Response(_error);
		}

		internal byte[] Edit(string json, Func<ICollection<T>, T, T> selector, Action<T, T> action)
		{
			var data = Read();
			var obj = JsonConvert.DeserializeObject<T>(json);
			var item = selector(data, obj);
			if (item != null)
			{
				action(item, obj);
				Write(data);
				return Response(item);
			}
			return Response(_error);
		}

		internal byte[] Filter(string json, Func<ICollection<T>, T, IEnumerable<T>> selector)
		{
			var data = Read();
			var obj = JsonConvert.DeserializeObject<T>(json);
			var item = selector(data, obj);
			return Response(item);
		}

		internal byte[] Filter(Func<ICollection<T>, T> precondition, Func<ICollection<T>, T, IEnumerable<T>> selector)
		{
			var data = Read();
			var obj = precondition(data);
			var item = selector(data, obj);
			return Response(item);
		}

		private ICollection<T> Read()
		{
			using (var fs = File.Open(Filename, FileMode.Open))
			using (var sr = new StreamReader(fs))
			using (var jr = new JsonTextReader(sr))
				return new JsonSerializer().Deserialize<List<T>>(jr) ?? new List<T>();
		}

		private string ReadRaw()
		{
			using (var fs = File.Open(Filename, FileMode.Open))
			using (var sr = new StreamReader(fs))
				return sr.ReadToEnd();
		}

		private void Write(IEnumerable<T> data)
		{
			using (var fs = File.Open(Filename, FileMode.Create))
			using (var sw = new StreamWriter(fs))
			using (var jw = new JsonTextWriter(sw))
				new JsonSerializer().Serialize(jw, data);
		}

		private static byte[] Response(T item)
		{
			return Response(new[] { item });
		}

		private static byte[] Response(IEnumerable<T> data)
		{
			return Response(JsonConvert.SerializeObject(data));
		}

		private static byte[] Response(string data)
		{
			return Encoding.UTF8.GetBytes(data);
		}
	}
}
