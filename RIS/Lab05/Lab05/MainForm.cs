using System;
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

		private void MainForm_Load(object sender, EventArgs e)
		{
			cargoBindingSource.DataSource = _modelContainer.CargoSet;
			carBindingSource.DataSource = _modelContainer.CarSet;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			_modelContainer.SaveChanges();
		}
	}
}
