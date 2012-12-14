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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dgvCargos = new System.Windows.Forms.DataGridView();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dgvCars = new System.Windows.Forms.DataGridView();
			this.btnSave = new System.Windows.Forms.Button();
			this.cargoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cargoToolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.carBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.carToolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.defaultStatusStrip = new System.Windows.Forms.StatusStrip();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tripsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cargoBindingNavigator)).BeginInit();
			this.cargoBindingNavigator.SuspendLayout();
			this.cargoToolStripContainer.ContentPanel.SuspendLayout();
			this.cargoToolStripContainer.TopToolStripPanel.SuspendLayout();
			this.cargoToolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).BeginInit();
			this.carBindingNavigator.SuspendLayout();
			this.carToolStripContainer.ContentPanel.SuspendLayout();
			this.carToolStripContainer.TopToolStripPanel.SuspendLayout();
			this.carToolStripContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCargos
			// 
			this.dgvCargos.AutoGenerateColumns = false;
			this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.dgvCargos.DataSource = this.cargoBindingSource;
			this.dgvCargos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCargos.Location = new System.Drawing.Point(0, 0);
			this.dgvCargos.Name = "dgvCargos";
			this.dgvCargos.Size = new System.Drawing.Size(550, 150);
			this.dgvCargos.TabIndex = 0;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			// 
			// sizeDataGridViewTextBoxColumn
			// 
			this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
			this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
			this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// cargoBindingSource
			// 
			this.cargoBindingSource.DataSource = typeof(Lab05.Cargo);
			// 
			// carBindingSource
			// 
			this.carBindingSource.DataSource = typeof(Lab05.Car);
			// 
			// dgvCars
			// 
			this.dgvCars.AutoGenerateColumns = false;
			this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.tripsDataGridViewTextBoxColumn});
			this.dgvCars.DataSource = this.carBindingSource;
			this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCars.Location = new System.Drawing.Point(0, 0);
			this.dgvCars.Name = "dgvCars";
			this.dgvCars.Size = new System.Drawing.Size(550, 150);
			this.dgvCars.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(242, 380);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save && Update";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cargoBindingNavigator
			// 
			this.cargoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.cargoBindingNavigator.BindingSource = this.cargoBindingSource;
			this.cargoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.cargoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.cargoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
			this.cargoBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.cargoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.toolStripSplitButton1});
			this.cargoBindingNavigator.Location = new System.Drawing.Point(3, 0);
			this.cargoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.cargoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.cargoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.cargoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.cargoBindingNavigator.Name = "cargoBindingNavigator";
			this.cargoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.cargoBindingNavigator.Size = new System.Drawing.Size(358, 25);
			this.cargoBindingNavigator.TabIndex = 3;
			this.cargoBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(106, 22);
			this.toolStripSplitButton1.Text = "Price Sort Order";
			// 
			// ascendingToolStripMenuItem
			// 
			this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
			this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.ascendingToolStripMenuItem.Text = "Ascending";
			this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
			// 
			// descendingToolStripMenuItem
			// 
			this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
			this.descendingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.descendingToolStripMenuItem.Text = "Descending";
			this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
			// 
			// cargoToolStripContainer
			// 
			// 
			// cargoToolStripContainer.ContentPanel
			// 
			this.cargoToolStripContainer.ContentPanel.Controls.Add(this.dgvCargos);
			this.cargoToolStripContainer.ContentPanel.Size = new System.Drawing.Size(550, 150);
			this.cargoToolStripContainer.Location = new System.Drawing.Point(8, 8);
			this.cargoToolStripContainer.Name = "cargoToolStripContainer";
			this.cargoToolStripContainer.Size = new System.Drawing.Size(550, 175);
			this.cargoToolStripContainer.TabIndex = 4;
			this.cargoToolStripContainer.Text = "toolStripContainer1";
			// 
			// cargoToolStripContainer.TopToolStripPanel
			// 
			this.cargoToolStripContainer.TopToolStripPanel.Controls.Add(this.cargoBindingNavigator);
			// 
			// carBindingNavigator
			// 
			this.carBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem1;
			this.carBindingNavigator.BindingSource = this.carBindingSource;
			this.carBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
			this.carBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
			this.carBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
			this.carBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.carBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBox1});
			this.carBindingNavigator.Location = new System.Drawing.Point(3, 0);
			this.carBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
			this.carBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
			this.carBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
			this.carBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
			this.carBindingNavigator.Name = "carBindingNavigator";
			this.carBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
			this.carBindingNavigator.Size = new System.Drawing.Size(432, 25);
			this.carBindingNavigator.TabIndex = 5;
			this.carBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem1
			// 
			this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
			this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
			this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem1.Text = "Add new";
			// 
			// bindingNavigatorCountItem1
			// 
			this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
			this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem1.Text = "of {0}";
			this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem1
			// 
			this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
			this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
			this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem1.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem1
			// 
			this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
			this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
			this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem1.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem1
			// 
			this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
			this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
			this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
			// 
			// bindingNavigatorSeparator3
			// 
			this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
			this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem1
			// 
			this.bindingNavigatorPositionItem1.AccessibleName = "Position";
			this.bindingNavigatorPositionItem1.AutoSize = false;
			this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
			this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem1.Text = "0";
			this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator4
			// 
			this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
			this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem1
			// 
			this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
			this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
			this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem1.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem1
			// 
			this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
			this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
			this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem1.Text = "Move last";
			// 
			// bindingNavigatorSeparator5
			// 
			this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
			this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
			this.toolStripLabel1.Text = "Filter By Trips";
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
			this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
			// 
			// carToolStripContainer
			// 
			// 
			// carToolStripContainer.ContentPanel
			// 
			this.carToolStripContainer.ContentPanel.Controls.Add(this.dgvCars);
			this.carToolStripContainer.ContentPanel.Size = new System.Drawing.Size(550, 150);
			this.carToolStripContainer.Location = new System.Drawing.Point(12, 199);
			this.carToolStripContainer.Name = "carToolStripContainer";
			this.carToolStripContainer.Size = new System.Drawing.Size(550, 175);
			this.carToolStripContainer.TabIndex = 6;
			this.carToolStripContainer.Text = "toolStripContainer2";
			// 
			// carToolStripContainer.TopToolStripPanel
			// 
			this.carToolStripContainer.TopToolStripPanel.Controls.Add(this.carBindingNavigator);
			// 
			// defaultStatusStrip
			// 
			this.defaultStatusStrip.Location = new System.Drawing.Point(0, 420);
			this.defaultStatusStrip.Name = "defaultStatusStrip";
			this.defaultStatusStrip.Size = new System.Drawing.Size(584, 22);
			this.defaultStatusStrip.TabIndex = 7;
			this.defaultStatusStrip.Text = "defaultStatusStrip";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// capacityDataGridViewTextBoxColumn
			// 
			this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
			this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
			this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
			// 
			// tripsDataGridViewTextBoxColumn
			// 
			this.tripsDataGridViewTextBoxColumn.DataPropertyName = "Trips";
			this.tripsDataGridViewTextBoxColumn.HeaderText = "Trips";
			this.tripsDataGridViewTextBoxColumn.Name = "tripsDataGridViewTextBoxColumn";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 442);
			this.Controls.Add(this.defaultStatusStrip);
			this.Controls.Add(this.carToolStripContainer);
			this.Controls.Add(this.cargoToolStripContainer);
			this.Controls.Add(this.btnSave);
			this.Name = "MainForm";
			this.Text = "Lab05";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cargoBindingNavigator)).EndInit();
			this.cargoBindingNavigator.ResumeLayout(false);
			this.cargoBindingNavigator.PerformLayout();
			this.cargoToolStripContainer.ContentPanel.ResumeLayout(false);
			this.cargoToolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.cargoToolStripContainer.TopToolStripPanel.PerformLayout();
			this.cargoToolStripContainer.ResumeLayout(false);
			this.cargoToolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).EndInit();
			this.carBindingNavigator.ResumeLayout(false);
			this.carBindingNavigator.PerformLayout();
			this.carToolStripContainer.ContentPanel.ResumeLayout(false);
			this.carToolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.carToolStripContainer.TopToolStripPanel.PerformLayout();
			this.carToolStripContainer.ResumeLayout(false);
			this.carToolStripContainer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCargos;
		private System.Windows.Forms.DataGridView dgvCars;
		private System.Windows.Forms.BindingSource cargoBindingSource;
		private System.Windows.Forms.BindingSource carBindingSource;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridViewTextBoxColumn cargoTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cargoSizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingNavigator cargoBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripContainer cargoToolStripContainer;
		private System.Windows.Forms.BindingNavigator carBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
		private System.Windows.Forms.ToolStripContainer carToolStripContainer;
		private System.Windows.Forms.StatusStrip defaultStatusStrip;
		private System.Windows.Forms.DataGridViewComboBoxColumn cargoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn carDataGridViewComboBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn carsDataGridViewComboBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tripsDataGridViewTextBoxColumn;
	}
}

