using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Lab01.Properties;

namespace Lab01.Forms
{
	public partial class GridEditorForm : Form
	{
		private int _size;

		public int GridSize
		{
			get
			{
				return _size;
			}
			set
			{
				_size = value;
				CreateGrid();
			}
		}

		public GridEditorForm()
		{
			InitializeComponent();
		}

		// ReSharper disable once InconsistentNaming
		private void btnOk_Click(object sender, EventArgs e)
		{
			if (_selectedCellsCount != _requiredCellsCount)
			{
				MessageBox.Show(Resources.Grid_SelectCells);
				return;
			}

			DialogResult = DialogResult.OK;
		}

		// ReSharper disable once InconsistentNaming
		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private int[][] _indices;
		private int _requiredCellsCount;
		private int _selectedCellsCount;
		private CheckBox[][] _cells;

		public bool[][] GetGrid()
		{
			var selectedCells = new bool[_size][];
			for (var i = 0; i < _size; i++)
			{
				selectedCells[i] = new bool[_size];
				for (var j = 0; j < _size; j++)
				{
					selectedCells[i][j] = _cells[i][j].Checked;
				}
			}
			return selectedCells;
		}

		private void CreateIndexMatrix()
		{
			_indices = new int[_size][];
			for (var i = 0; i < _size; i++)
			{
				_indices[i] = new int[_size];
			}

			var currentIndex = 1;
			for (var i = 0; i < _size; i++)
			{
				for (var j = 0; j < _size; j++)
				{
					if (_indices[i][j] == 0)
					{
						_indices[i][j] = currentIndex;
						_indices[j][_size - 1 - i] = currentIndex;
						_indices[_size - 1 - i][_size - 1 - j] = currentIndex;
						_indices[_size - 1 - j][i] = currentIndex;
						currentIndex++;
					}
				}
			}
			_requiredCellsCount = currentIndex - 1 - (_size % 2 == 0 ? 0 : 1);
			_selectedCellsCount = 0;
		}

		private void CreateGrid()
		{
			CreateIndexMatrix();
			var cellSize = (float)100 / _size;

			GridEditFormTableLayoutPanel.SuspendLayout();
			GridEditFormTableLayoutPanel.RowStyles.Clear();
			GridEditFormTableLayoutPanel.ColumnStyles.Clear();
			GridEditFormTableLayoutPanel.Controls.Clear();

			GridEditFormTableLayoutPanel.RowCount = _size;
			GridEditFormTableLayoutPanel.ColumnCount = _size;

			_cells = new CheckBox[_size][];
			for (var i = 0; i < _size; i++)
			{
				GridEditFormTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, cellSize));
				_cells[i] = new CheckBox[_size];

				for (var j = 0; j < _size; j++)
				{
					_cells[i][j] = new CheckBox
					{
						Anchor = AnchorStyles.None,
						Dock = DockStyle.Fill,
						CheckAlign = ContentAlignment.MiddleCenter,
						Name = _indices[i][j].ToString(CultureInfo.InvariantCulture),
						Enabled = !(_size % 2 == 1 && i == (_size / 2) && i == j)
					};
					_cells[i][j].Click += CellClick;
					GridEditFormTableLayoutPanel.Controls.Add(_cells[i][j], j, i);
					GridEditFormTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, cellSize));
				}
			}

			GridEditFormTableLayoutPanel.ResumeLayout(true);
		}

		private void CellClick(Object sender, EventArgs e)
		{
			var checkbox = (CheckBox)sender;
			var index = Int32.Parse(checkbox.Name);

			if (checkbox.Checked)
				_selectedCellsCount++;
			else
				_selectedCellsCount--;

			for (var i = 0; i < _size; i++)
			{
				for (var j = 0; j < _size; j++)
				{
					if (_indices[i][j] == index && _cells[i][j] != checkbox)
					{
						_cells[i][j].Enabled = !checkbox.Checked;
					}
				}
			}
		}
	}
}
