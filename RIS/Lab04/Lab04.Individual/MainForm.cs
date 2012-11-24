using System;
using System.Windows.Forms;

namespace Lab04.Individual
{
	public partial class MainForm : Form
	{
		private readonly MediaLibrary _mediaLibrary = new MediaLibrary();

		public MainForm()
		{
			InitializeComponent();
			RefreshDataGrid();
		}

		private void RefreshDataGrid()
		{
			dgvMediaLibrary.AutoGenerateColumns = false;
			dgvMediaLibrary.DataSource = null;
			dgvMediaLibrary.DataSource = _mediaLibrary.Tracks;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_mediaLibrary.Add(txtArtist.Text, txtAlbum.Text, txtTrack.Text);
			txtArtist.Text = txtAlbum.Text = txtTrack.Text = null;
			RefreshDataGrid();
		}

		private void btnShowAll_Click(object sender, EventArgs e)
		{
			txtFilter.Text = null;
			_mediaLibrary.Reset();
			RefreshDataGrid();
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			_mediaLibrary.Filter(txtFilter.Text);
			RefreshDataGrid();
		}

		private void btnMaxAlbums_Click(object sender, EventArgs e)
		{
			txtFilter.Text = null;
			_mediaLibrary.FilterMaxAlbums();
			RefreshDataGrid();
		}
	}
}
