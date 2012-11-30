namespace Lab04.Server
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.txtListen = new System.Windows.Forms.Button();
			this.bwListener = new System.ComponentModel.BackgroundWorker();
			this.rbMediaLibraryClass = new System.Windows.Forms.RadioButton();
			this.rbThreadClass = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(13, 13);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(259, 185);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// txtListen
			// 
			this.txtListen.Location = new System.Drawing.Point(13, 227);
			this.txtListen.Name = "txtListen";
			this.txtListen.Size = new System.Drawing.Size(259, 23);
			this.txtListen.TabIndex = 3;
			this.txtListen.Text = "Listen";
			this.txtListen.UseVisualStyleBackColor = true;
			this.txtListen.Click += new System.EventHandler(this.txtListen_Click);
			// 
			// bwListener
			// 
			this.bwListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwListener_DoWork);
			// 
			// rbMediaLibraryClass
			// 
			this.rbMediaLibraryClass.AutoSize = true;
			this.rbMediaLibraryClass.Location = new System.Drawing.Point(149, 205);
			this.rbMediaLibraryClass.Name = "rbMediaLibraryClass";
			this.rbMediaLibraryClass.Size = new System.Drawing.Size(88, 17);
			this.rbMediaLibraryClass.TabIndex = 2;
			this.rbMediaLibraryClass.Text = "Media Library";
			this.rbMediaLibraryClass.UseVisualStyleBackColor = true;
			// 
			// rbThreadClass
			// 
			this.rbThreadClass.AutoSize = true;
			this.rbThreadClass.Checked = true;
			this.rbThreadClass.Location = new System.Drawing.Point(58, 205);
			this.rbThreadClass.Name = "rbThreadClass";
			this.rbThreadClass.Size = new System.Drawing.Size(52, 17);
			this.rbThreadClass.TabIndex = 1;
			this.rbThreadClass.TabStop = true;
			this.rbThreadClass.Text = "Trees";
			this.rbThreadClass.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.rbThreadClass);
			this.Controls.Add(this.rbMediaLibraryClass);
			this.Controls.Add(this.txtListen);
			this.Controls.Add(this.richTextBox1);
			this.Name = "MainForm";
			this.Text = "Lab04 Server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button txtListen;
		private System.ComponentModel.BackgroundWorker bwListener;
		private System.Windows.Forms.RadioButton rbMediaLibraryClass;
		private System.Windows.Forms.RadioButton rbThreadClass;
	}
}

