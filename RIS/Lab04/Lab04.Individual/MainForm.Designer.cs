namespace Lab04.Individual
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblArtist = new System.Windows.Forms.Label();
			this.lblTrack = new System.Windows.Forms.Label();
			this.lblAlbum = new System.Windows.Forms.Label();
			this.txtArtist = new System.Windows.Forms.TextBox();
			this.txtTrack = new System.Windows.Forms.TextBox();
			this.txtAlbum = new System.Windows.Forms.TextBox();
			this.dgvMediaLibrary = new System.Windows.Forms.DataGridView();
			this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Track = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnShowAll = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.btnFilter = new System.Windows.Forms.Button();
			this.btnMaxAlbums = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMediaLibrary)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(341, 190);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblArtist
			// 
			this.lblArtist.AutoSize = true;
			this.lblArtist.Location = new System.Drawing.Point(13, 175);
			this.lblArtist.Name = "lblArtist";
			this.lblArtist.Size = new System.Drawing.Size(30, 13);
			this.lblArtist.TabIndex = 2;
			this.lblArtist.Text = "Artist";
			// 
			// lblTrack
			// 
			this.lblTrack.AutoSize = true;
			this.lblTrack.Location = new System.Drawing.Point(117, 175);
			this.lblTrack.Name = "lblTrack";
			this.lblTrack.Size = new System.Drawing.Size(35, 13);
			this.lblTrack.TabIndex = 3;
			this.lblTrack.Text = "Track";
			// 
			// lblAlbum
			// 
			this.lblAlbum.AutoSize = true;
			this.lblAlbum.Location = new System.Drawing.Point(224, 175);
			this.lblAlbum.Name = "lblAlbum";
			this.lblAlbum.Size = new System.Drawing.Size(36, 13);
			this.lblAlbum.TabIndex = 4;
			this.lblAlbum.Text = "Album";
			// 
			// txtArtist
			// 
			this.txtArtist.Location = new System.Drawing.Point(13, 192);
			this.txtArtist.Name = "txtArtist";
			this.txtArtist.Size = new System.Drawing.Size(100, 20);
			this.txtArtist.TabIndex = 5;
			// 
			// txtTrack
			// 
			this.txtTrack.Location = new System.Drawing.Point(120, 192);
			this.txtTrack.Name = "txtTrack";
			this.txtTrack.Size = new System.Drawing.Size(100, 20);
			this.txtTrack.TabIndex = 6;
			// 
			// txtAlbum
			// 
			this.txtAlbum.Location = new System.Drawing.Point(226, 192);
			this.txtAlbum.Name = "txtAlbum";
			this.txtAlbum.Size = new System.Drawing.Size(100, 20);
			this.txtAlbum.TabIndex = 7;
			// 
			// dgvMediaLibrary
			// 
			this.dgvMediaLibrary.AllowUserToAddRows = false;
			this.dgvMediaLibrary.AllowUserToDeleteRows = false;
			this.dgvMediaLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMediaLibrary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artist,
            this.Album,
            this.Track});
			this.dgvMediaLibrary.Location = new System.Drawing.Point(16, 13);
			this.dgvMediaLibrary.Name = "dgvMediaLibrary";
			this.dgvMediaLibrary.ReadOnly = true;
			this.dgvMediaLibrary.Size = new System.Drawing.Size(400, 150);
			this.dgvMediaLibrary.TabIndex = 8;
			// 
			// Artist
			// 
			this.Artist.DataPropertyName = "Artist";
			this.Artist.HeaderText = "Artist";
			this.Artist.Name = "Artist";
			this.Artist.ReadOnly = true;
			// 
			// Album
			// 
			this.Album.DataPropertyName = "Album";
			this.Album.HeaderText = "Album";
			this.Album.Name = "Album";
			this.Album.ReadOnly = true;
			// 
			// Track
			// 
			this.Track.DataPropertyName = "Track";
			this.Track.HeaderText = "Track";
			this.Track.Name = "Track";
			this.Track.ReadOnly = true;
			// 
			// btnShowAll
			// 
			this.btnShowAll.Location = new System.Drawing.Point(260, 227);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(75, 23);
			this.btnShowAll.TabIndex = 9;
			this.btnShowAll.Text = "Show All";
			this.btnShowAll.UseVisualStyleBackColor = true;
			this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 232);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Filter by Artist";
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(88, 229);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(85, 20);
			this.txtFilter.TabIndex = 11;
			// 
			// btnFilter
			// 
			this.btnFilter.Location = new System.Drawing.Point(179, 227);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(75, 23);
			this.btnFilter.TabIndex = 12;
			this.btnFilter.Text = "Filter";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// btnMaxAlbums
			// 
			this.btnMaxAlbums.Location = new System.Drawing.Point(341, 227);
			this.btnMaxAlbums.Name = "btnMaxAlbums";
			this.btnMaxAlbums.Size = new System.Drawing.Size(75, 50);
			this.btnMaxAlbums.TabIndex = 13;
			this.btnMaxAlbums.Text = "Show Artist\r\nWith Max Albums";
			this.btnMaxAlbums.UseVisualStyleBackColor = true;
			this.btnMaxAlbums.Click += new System.EventHandler(this.btnMaxAlbums_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 282);
			this.Controls.Add(this.btnMaxAlbums);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.dgvMediaLibrary);
			this.Controls.Add(this.txtAlbum);
			this.Controls.Add(this.txtTrack);
			this.Controls.Add(this.txtArtist);
			this.Controls.Add(this.lblAlbum);
			this.Controls.Add(this.lblTrack);
			this.Controls.Add(this.lblArtist);
			this.Controls.Add(this.btnAdd);
			this.Name = "MainForm";
			this.Text = "Lab04 Individual";
			((System.ComponentModel.ISupportInitialize)(this.dgvMediaLibrary)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblArtist;
		private System.Windows.Forms.Label lblTrack;
		private System.Windows.Forms.Label lblAlbum;
		private System.Windows.Forms.TextBox txtArtist;
		private System.Windows.Forms.TextBox txtTrack;
		private System.Windows.Forms.TextBox txtAlbum;
		private System.Windows.Forms.DataGridView dgvMediaLibrary;
		private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
		private System.Windows.Forms.DataGridViewTextBoxColumn Album;
		private System.Windows.Forms.DataGridViewTextBoxColumn Track;
		private System.Windows.Forms.Button btnShowAll;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Button btnMaxAlbums;
	}
}

