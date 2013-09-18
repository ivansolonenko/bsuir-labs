using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lab01.Cryptography;
using Lab01.Properties;
using Labs.Shared.Cryptography.EncryptionMethods;

namespace Lab01.Forms
{
	public partial class MainForm : Form
	{
		private readonly Dictionary<RadioButton, Type> _radioButtons;

		public MainForm()
		{
			InitializeComponent();

			CryptoManager.Instance.SetTextboxes(txtLeftFileContent, txtRightFileContent);
			MainFormPropertyGrid.SelectedObject = CryptoManager.Instance.Settings;

			_radioButtons = new Dictionary<RadioButton, Type>
				{
					{rbRailwayFenceMethod, typeof(RailwayFenceMethod)},
					{rbColumnsMethod, typeof(ColumnsMethod)},
					{rbGridMethod, typeof(GridMethod)},
					{rbCaesarMethod, typeof(CaesarMethod)},
				};
			_radioButtons.First().Key.Checked = true;
		}

		// ReSharper disable once InconsistentNaming
		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			CryptoManager.Instance.Encrypt(_radioButtons.Single(x => x.Key.Checked).Value);
		}

		// ReSharper disable once InconsistentNaming
		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			CryptoManager.Instance.Decrypt(_radioButtons.Single(x => x.Key.Checked).Value);
		}

		// ReSharper disable once InconsistentNaming
		private void openLeftFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MainFormOpenFileDialog.ShowDialog() != DialogResult.OK)
				return;

			using (var stream = MainFormOpenFileDialog.OpenFile())
				CryptoManager.Instance.LoadFile(CryptoManager.Panels.Left, stream);

			lblLeftFileName.Text = MainFormOpenFileDialog.FileName;
		}

		// ReSharper disable once InconsistentNaming
		private void openRightFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MainFormOpenFileDialog.ShowDialog() != DialogResult.OK)
				return;

			using (var stream = MainFormOpenFileDialog.OpenFile())
				CryptoManager.Instance.LoadFile(CryptoManager.Panels.Right, stream);

			lblRightFileName.Text = MainFormOpenFileDialog.FileName;
		}

		// ReSharper disable once InconsistentNaming
		private void closeLeftFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtLeftFileContent.Clear();
			txtLeftFileContent.ClearUndo();
			lblLeftFileName.Text = Resources.NoFile;
		}

		// ReSharper disable once InconsistentNaming
		private void closeRightFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtRightFileContent.Clear();
			txtRightFileContent.ClearUndo();
			lblRightFileName.Text = Resources.NoFile;
		}

		// ReSharper disable once InconsistentNaming
		private void saveLeftFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MainFormSaveFileDialog.ShowDialog() != DialogResult.OK)
				return;

			using (var stream = MainFormSaveFileDialog.OpenFile())
				CryptoManager.Instance.SaveFile(CryptoManager.Panels.Left, stream);
		}

		// ReSharper disable once InconsistentNaming
		private void saveRightFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MainFormSaveFileDialog.ShowDialog() != DialogResult.OK)
				return;

			using (var stream = MainFormSaveFileDialog.OpenFile())
				CryptoManager.Instance.SaveFile(CryptoManager.Panels.Right, stream);
		}
	}
}
