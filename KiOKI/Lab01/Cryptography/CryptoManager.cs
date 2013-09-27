using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Lab01.Attributes;
using Lab01.TypeConverters;
using Lab01.UITypeEditors;
using Labs.Shared.Cryptography.EncryptionMethods;
using Labs.Shared.Cryptography.Interfaces;

namespace Lab01.Cryptography
{
	internal class CryptoManager
	{
		#region Singleton

		private static CryptoManager _instance;

		public static CryptoManager Instance
		{
			get { return _instance ?? (_instance = new CryptoManager()); }
		}

		#endregion

		#region Settings

		internal class CryptoManagerSettings
		{
			[LocalizedCategory("Methods_RailwayFence")]
			[LocalizedDisplayName("Key")]
			public int RailwayFenceKey { get; set; }

			[LocalizedCategory("Methods_Columns")]
			[LocalizedDisplayName("Key")]
			public string ColumnsKey { get; set; }

			[LocalizedCategory("Methods_Grid")]
			[LocalizedDisplayName("Grid_Size")]
			public int GridSize { get; set; }

			[LocalizedCategory("Methods_Grid")]
			[LocalizedDisplayName("Grid")]
			[Editor(typeof(GridEditor), typeof(UITypeEditor))]
			[TypeConverter(typeof(GridConverter))]
			public bool[][] GridBoolChecked { get; set; }

			[LocalizedCategory("Methods_Caesar")]
			[LocalizedDisplayName("Key")]
			public int CaesarK { get; set; }

			[LocalizedCategory("Methods_Caesar")]
			[LocalizedDisplayName("AlphabethLength")]
			public int CaesarN { get; set; }
		}

		internal CryptoManagerSettings Settings { get; private set; }

		#endregion

		#region Panels

		internal enum Panels
		{
			Left,
			Right
		}

		private class Panel
		{
			public string Content
			{
				get { return TextBox.Text; }
				set { TextBox.Text = value; }
			}

			// ReSharper disable once MemberCanBePrivate.Local
			public TextBox TextBox { get; set; }

			// ReSharper disable once UnusedAutoPropertyAccessor.Local
			public Encoding Encoding { get; set; }
		}

		#endregion

		private Dictionary<Panels, Panel> _panels;

		private CryptoManager()
		{
			Settings = new CryptoManagerSettings
				{
					RailwayFenceKey = 4,
					ColumnsKey = Guid.NewGuid().ToString("N"),
					CaesarK = 0,
					CaesarN = 65536,
					GridSize = 4,
					GridBoolChecked = null
				};
		}

		public void SetTextboxes(TextBox leftFileTextBox, TextBox rightFileTextBox)
		{
			_panels = new Dictionary<Panels, Panel>
				{
					{Panels.Left, new Panel { TextBox = leftFileTextBox }},
					{Panels.Right, new Panel { TextBox = rightFileTextBox }}
				};
		}

		public void LoadFile(Panels panel, Stream fstream)
		{
			using (var reader = new StreamReader(fstream))
			{
				_panels[panel].Content = reader.ReadToEnd();
				_panels[panel].Encoding = reader.CurrentEncoding;
			}
		}

		public void SaveFile(Panels panel, Stream fstream)
		{
			using (var writer = new StreamWriter(fstream, Encoding.Unicode))
			{
				writer.Write(_panels[panel].Content);
			}
		}

		public void Encrypt(Type type)
		{
			var method = GetEncryptionMethod(type);
			_panels[Panels.Right].Content = method.Encrypt(_panels[Panels.Left].Content);
		}

		public void Decrypt(Type type)
		{
			var method = GetEncryptionMethod(type);
			_panels[Panels.Left].Content = method.Decrypt(_panels[Panels.Right].Content);
		}

		private IEncryptionMethod GetEncryptionMethod(Type type)
		{
			if (type == typeof(CaesarMethod))
				return new CaesarMethod(Settings.CaesarK, Settings.CaesarN);

			if (type == typeof(GridMethod))
				return new GridMethod(Settings.GridSize, Settings.GridBoolChecked);

			if (type == typeof(ColumnsMethod))
				return new ColumnsMethod(Settings.ColumnsKey);

			if (type == typeof(RailwayFenceMethod))
				return new RailwayFenceMethod(Settings.RailwayFenceKey);

			throw new ArgumentException("type");
		}
	}
}
