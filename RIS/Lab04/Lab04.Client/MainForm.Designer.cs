namespace Lab04.Client
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
			this.lbServiceInfo = new System.Windows.Forms.ListBox();
			this.rbView = new System.Windows.Forms.RadioButton();
			this.rbAdd = new System.Windows.Forms.RadioButton();
			this.rbDelete = new System.Windows.Forms.RadioButton();
			this.rbEdit = new System.Windows.Forms.RadioButton();
			this.rbFind = new System.Windows.Forms.RadioButton();
			this.btnExecute = new System.Windows.Forms.Button();
			this.btnSendToServer = new System.Windows.Forms.Button();
			this.cbShowStatus = new System.Windows.Forms.CheckBox();
			this.txtDistrict = new System.Windows.Forms.TextBox();
			this.lblDistrict = new System.Windows.Forms.Label();
			this.lblTree = new System.Windows.Forms.Label();
			this.lblAmount = new System.Windows.Forms.Label();
			this.txtTree = new System.Windows.Forms.TextBox();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.rtbContent = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lbServiceInfo
			// 
			this.lbServiceInfo.FormattingEnabled = true;
			this.lbServiceInfo.Location = new System.Drawing.Point(262, 133);
			this.lbServiceInfo.Name = "lbServiceInfo";
			this.lbServiceInfo.Size = new System.Drawing.Size(237, 56);
			this.lbServiceInfo.TabIndex = 0;
			// 
			// rbView
			// 
			this.rbView.AutoSize = true;
			this.rbView.Location = new System.Drawing.Point(181, 13);
			this.rbView.Name = "rbView";
			this.rbView.Size = new System.Drawing.Size(93, 17);
			this.rbView.TabIndex = 1;
			this.rbView.Text = "Просмотреть";
			this.rbView.UseVisualStyleBackColor = true;
			this.rbView.CheckedChanged += new System.EventHandler(this.rbView_CheckedChanged);
			// 
			// rbAdd
			// 
			this.rbAdd.AutoSize = true;
			this.rbAdd.Location = new System.Drawing.Point(181, 37);
			this.rbAdd.Name = "rbAdd";
			this.rbAdd.Size = new System.Drawing.Size(75, 17);
			this.rbAdd.TabIndex = 2;
			this.rbAdd.Text = "Добавить";
			this.rbAdd.UseVisualStyleBackColor = true;
			this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
			// 
			// rbDelete
			// 
			this.rbDelete.AutoSize = true;
			this.rbDelete.Enabled = false;
			this.rbDelete.Location = new System.Drawing.Point(181, 61);
			this.rbDelete.Name = "rbDelete";
			this.rbDelete.Size = new System.Drawing.Size(68, 17);
			this.rbDelete.TabIndex = 3;
			this.rbDelete.Text = "Удалить";
			this.rbDelete.UseVisualStyleBackColor = true;
			// 
			// rbEdit
			// 
			this.rbEdit.AutoSize = true;
			this.rbEdit.Enabled = false;
			this.rbEdit.Location = new System.Drawing.Point(181, 85);
			this.rbEdit.Name = "rbEdit";
			this.rbEdit.Size = new System.Drawing.Size(102, 17);
			this.rbEdit.TabIndex = 4;
			this.rbEdit.Text = "Редактировать";
			this.rbEdit.UseVisualStyleBackColor = true;
			// 
			// rbFind
			// 
			this.rbFind.AutoSize = true;
			this.rbFind.Enabled = false;
			this.rbFind.Location = new System.Drawing.Point(181, 109);
			this.rbFind.Name = "rbFind";
			this.rbFind.Size = new System.Drawing.Size(56, 17);
			this.rbFind.TabIndex = 5;
			this.rbFind.Text = "Найти";
			this.rbFind.UseVisualStyleBackColor = true;
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(181, 133);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(75, 23);
			this.btnExecute.TabIndex = 6;
			this.btnExecute.Text = "Выполнить";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// btnSendToServer
			// 
			this.btnSendToServer.Location = new System.Drawing.Point(141, 166);
			this.btnSendToServer.Name = "btnSendToServer";
			this.btnSendToServer.Size = new System.Drawing.Size(115, 23);
			this.btnSendToServer.TabIndex = 7;
			this.btnSendToServer.Text = "Послать на сервер";
			this.btnSendToServer.UseVisualStyleBackColor = true;
			// 
			// cbShowStatus
			// 
			this.cbShowStatus.AutoSize = true;
			this.cbShowStatus.Location = new System.Drawing.Point(12, 170);
			this.cbShowStatus.Name = "cbShowStatus";
			this.cbShowStatus.Size = new System.Drawing.Size(125, 17);
			this.cbShowStatus.TabIndex = 8;
			this.cbShowStatus.Text = "Показывать статус";
			this.cbShowStatus.UseVisualStyleBackColor = true;
			this.cbShowStatus.CheckedChanged += new System.EventHandler(this.cbShowStatus_CheckedChanged);
			// 
			// txtDistrict
			// 
			this.txtDistrict.Location = new System.Drawing.Point(399, 61);
			this.txtDistrict.Name = "txtDistrict";
			this.txtDistrict.Size = new System.Drawing.Size(100, 20);
			this.txtDistrict.TabIndex = 9;
			// 
			// lblDistrict
			// 
			this.lblDistrict.AutoSize = true;
			this.lblDistrict.Location = new System.Drawing.Point(307, 65);
			this.lblDistrict.Name = "lblDistrict";
			this.lblDistrict.Size = new System.Drawing.Size(38, 13);
			this.lblDistrict.TabIndex = 10;
			this.lblDistrict.Text = "Район";
			// 
			// lblTree
			// 
			this.lblTree.AutoSize = true;
			this.lblTree.Location = new System.Drawing.Point(307, 89);
			this.lblTree.Name = "lblTree";
			this.lblTree.Size = new System.Drawing.Size(46, 13);
			this.lblTree.TabIndex = 11;
			this.lblTree.Text = "Дерево";
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Location = new System.Drawing.Point(307, 111);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(66, 13);
			this.lblAmount.TabIndex = 12;
			this.lblAmount.Text = "Количество";
			// 
			// txtTree
			// 
			this.txtTree.Location = new System.Drawing.Point(399, 85);
			this.txtTree.Name = "txtTree";
			this.txtTree.Size = new System.Drawing.Size(100, 20);
			this.txtTree.TabIndex = 13;
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(399, 109);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(100, 20);
			this.txtAmount.TabIndex = 14;
			// 
			// rtbContent
			// 
			this.rtbContent.Location = new System.Drawing.Point(13, 13);
			this.rtbContent.Name = "rtbContent";
			this.rtbContent.Size = new System.Drawing.Size(162, 143);
			this.rtbContent.TabIndex = 15;
			this.rtbContent.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 200);
			this.Controls.Add(this.rtbContent);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.txtTree);
			this.Controls.Add(this.lblAmount);
			this.Controls.Add(this.lblTree);
			this.Controls.Add(this.lblDistrict);
			this.Controls.Add(this.txtDistrict);
			this.Controls.Add(this.cbShowStatus);
			this.Controls.Add(this.btnSendToServer);
			this.Controls.Add(this.btnExecute);
			this.Controls.Add(this.rbFind);
			this.Controls.Add(this.rbEdit);
			this.Controls.Add(this.rbDelete);
			this.Controls.Add(this.rbAdd);
			this.Controls.Add(this.rbView);
			this.Controls.Add(this.lbServiceInfo);
			this.Name = "MainForm";
			this.Text = "Lab04 Client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbServiceInfo;
		private System.Windows.Forms.RadioButton rbView;
		private System.Windows.Forms.RadioButton rbAdd;
		private System.Windows.Forms.RadioButton rbDelete;
		private System.Windows.Forms.RadioButton rbEdit;
		private System.Windows.Forms.RadioButton rbFind;
		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.Button btnSendToServer;
		private System.Windows.Forms.CheckBox cbShowStatus;
		private System.Windows.Forms.TextBox txtDistrict;
		private System.Windows.Forms.Label lblDistrict;
		private System.Windows.Forms.Label lblTree;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.TextBox txtTree;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.RichTextBox rtbContent;
	}
}

