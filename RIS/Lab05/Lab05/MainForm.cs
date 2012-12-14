using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab05
{
	public partial class MainForm : Form
	{
		private readonly LogisticsModelContainer _modelContainer = new LogisticsModelContainer();

		public MainForm()
		{
			InitializeComponent();
		}

		// ReSharper disable InconsistentNaming
		private void MainForm_Load(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			cargoBindingSource.DataSource = _modelContainer.Cargos;
			carBindingSource.DataSource = _modelContainer.Cars;
		}

		// ReSharper disable InconsistentNaming
		private void btnSave_Click(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			_modelContainer.SaveChanges();
		}

		// ReSharper disable InconsistentNaming
		private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
		// ReSharper restore InconsistentNaming
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				e.Handled = true;
		}

		// ReSharper disable InconsistentNaming
		private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			if (!string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
			{
				var trips = Convert.ToInt32(toolStripTextBox1.Text);
				carBindingSource.DataSource = _modelContainer.Cars.Where(x => x.Trips == trips);
			}
			else
				carBindingSource.DataSource = _modelContainer.Cars;
		}

		// ReSharper disable InconsistentNaming
		private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			cargoBindingSource.DataSource = _modelContainer.Cargos.OrderBy(x => x.Price);
		}

		// ReSharper disable InconsistentNaming
		private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			cargoBindingSource.DataSource = _modelContainer.Cargos.OrderByDescending(x => x.Price);
		}
	}
}
