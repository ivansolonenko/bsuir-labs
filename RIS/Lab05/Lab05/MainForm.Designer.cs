namespace Lab05
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
			this.components = new System.ComponentModel.Container();
			this.dgvCargo = new System.Windows.Forms.DataGridView();
			this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnSave = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cargoTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cargoSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCargo
			// 
			this.dgvCargo.AutoGenerateColumns = false;
			this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cargoTitleDataGridViewTextBoxColumn,
            this.cargoSizeDataGridViewTextBoxColumn});
			this.dgvCargo.DataSource = this.cargoBindingSource;
			this.dgvCargo.Location = new System.Drawing.Point(12, 12);
			this.dgvCargo.Name = "dgvCargo";
			this.dgvCargo.Size = new System.Drawing.Size(360, 150);
			this.dgvCargo.TabIndex = 0;
			// 
			// cargoBindingSource
			// 
			this.cargoBindingSource.DataSource = typeof(Lab05.Cargo);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.capacityDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.carBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(12, 168);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(360, 150);
			this.dataGridView2.TabIndex = 1;
			// 
			// carBindingSource
			// 
			this.carBindingSource.DataSource = typeof(Lab05.Car);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(13, 325);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save && Update";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cargoTitleDataGridViewTextBoxColumn
			// 
			this.cargoTitleDataGridViewTextBoxColumn.DataPropertyName = "CargoTitle";
			this.cargoTitleDataGridViewTextBoxColumn.HeaderText = "CargoTitle";
			this.cargoTitleDataGridViewTextBoxColumn.Name = "cargoTitleDataGridViewTextBoxColumn";
			// 
			// cargoSizeDataGridViewTextBoxColumn
			// 
			this.cargoSizeDataGridViewTextBoxColumn.DataPropertyName = "CargoSize";
			this.cargoSizeDataGridViewTextBoxColumn.HeaderText = "CargoSize";
			this.cargoSizeDataGridViewTextBoxColumn.Name = "cargoSizeDataGridViewTextBoxColumn";
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// capacityDataGridViewTextBoxColumn
			// 
			this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
			this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
			this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 412);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dgvCargo);
			this.Name = "MainForm";
			this.Text = "Lab05";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCargo;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.BindingSource cargoBindingSource;
		private System.Windows.Forms.BindingSource carBindingSource;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cargoTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cargoSizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
	}
}

