using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab04.Client
{
	public partial class MainForm : Form
	{
		private static TcpClient TcpClient
		{
			get { return new TcpClient("localhost", 5555); }
		}

		public MainForm()
		{
			InitializeComponent();

			txtId.Enabled =
			txtDistrict.Enabled =
			txtTree.Enabled =
			txtAmount.Enabled = false;

			lbServiceInfo.Visible = false;
		}

		// ReSharper disable InconsistentNaming
		private void btnExecute_Click(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			// Создаем объект класса NetworkStream и ассоциируем его объектом класса TcpClient
			NetworkStream ns;
			try
			{
				ns = TcpClient.GetStream();
			}
			catch (SocketException)
			{
				// ReSharper disable LocalizableElement
				MessageBox.Show("The server is not started", "Connection Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// ReSharper restore LocalizableElement
				return;
			}

			string res;

			if (rbView.Checked)
				res = string.Format("view|");
			else if (rbAdd.Checked)
				res = string.Format("add|{0}", JsonConvert.SerializeObject(new { Id = 0, District = txtDistrict.Text, Tree = txtTree.Text, Amount = txtAmount.Text }));
			else if (rbDelete.Checked)
				res = string.Format("delete|{0}", JsonConvert.SerializeObject(new { Id = Convert.ToInt32(txtId.Text) }));
			else if (rbEdit.Checked)
				res = string.Format("edit|{0}", JsonConvert.SerializeObject(new { Id = Convert.ToInt32(txtId.Text), District = txtDistrict.Text, Tree = txtTree.Text, Amount = txtAmount.Text }));
			else if (rbFind.Checked)
				res = string.Format("find|{0}", JsonConvert.SerializeObject(new { Amount = txtAmount.Text }));
			else if (rbSort.Checked)
				res = string.Format("sort|");
			else
				return;

			// Создаем переменные типа byte[] для отправки запроса и получения результата
			var sent = Encoding.UTF8.GetBytes(res);
			var recieved = new byte[1024];

			// Отправляем запрос на сервер
			ns.Write(sent, 0, sent.Length);

			// Получаем результат выполнения запроса с сервера
			ns.Read(recieved, 0, recieved.Length);

			// Отображаем полученный результат в клиентском RichTextBox
			rtbContent.Text = string.Empty;
			foreach (var o in JsonConvert.DeserializeObject<List<dynamic>>(Encoding.UTF8.GetString(recieved).Trim('\0')))
				rtbContent.Text += string.Format("Id: {0}; District: {1}; Tree: {2}; Amount: {3}" + Environment.NewLine, o.Id, o.District, o.Tree, o.Amount);

			// Очистим поля данных
			txtId.Text = txtDistrict.Text = txtTree.Text = txtAmount.Text = null;

			var status = string.Empty;
			if (rbView.Checked)
				status = "=> Command sent:view data";
			else if (rbAdd.Checked)
				status = "=> Command sent:add data";
			else if (rbDelete.Checked)
				status = "=> Command sent:delete data";
			else if (rbEdit.Checked)
				status = "=> Command sent:edit data";
			else if (rbFind.Checked)
				status = "=> Command sent:find data";
			else if (rbSort.Checked)
				status = "=> Command sent:sort data";

			// Отображеем служебную информацию в клиентском ListBox
			lbServiceInfo.Items.Add(status);
		}

		// ReSharper disable InconsistentNaming
		private void rbView_CheckedChanged(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			if (!rbView.Checked)
				return;

			txtId.Enabled =
			txtDistrict.Enabled =
			txtTree.Enabled =
			txtAmount.Enabled = false;
		}

		// ReSharper disable InconsistentNaming
		private void rbAdd_CheckedChanged(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			if (!rbAdd.Checked)
				return;

			txtId.Enabled = false;
			txtDistrict.Enabled =
			txtTree.Enabled =
			txtAmount.Enabled = true;
		}

		// ReSharper disable InconsistentNaming
		private void rbDelete_CheckedChanged(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			if (!rbDelete.Checked)
				return;

			txtId.Enabled = true;
			txtDistrict.Enabled =
			txtTree.Enabled =
			txtAmount.Enabled = false;
		}

		// ReSharper disable InconsistentNaming
		private void rbEdit_CheckedChanged(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			if (!rbEdit.Checked)
				return;

			txtId.Enabled =
			txtDistrict.Enabled =
			txtTree.Enabled =
			txtAmount.Enabled = true;
		}

		// ReSharper disable InconsistentNaming
		private void rbFind_CheckedChanged(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			if (!rbFind.Checked)
				return;

			txtId.Enabled =
			txtDistrict.Enabled =
			txtTree.Enabled = false;
			txtAmount.Enabled = true;
		}

		// ReSharper disable InconsistentNaming
		private void rbSort_CheckedChanged(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			if (!rbSort.Checked)
				return;

			txtId.Enabled =
			txtDistrict.Enabled =
			txtTree.Enabled =
			txtAmount.Enabled = false;
		}

		// ReSharper disable InconsistentNaming
		private void cbShowStatus_CheckedChanged(object sender, EventArgs e)
		// ReSharper restore InconsistentNaming
		{
			lbServiceInfo.Visible = cbShowStatus.Checked;
		}

		// ReSharper disable InconsistentNaming
		private void txtId_KeyPress(object sender, KeyPressEventArgs e)
		// ReSharper restore InconsistentNaming
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				e.Handled = true;
		}
	}
}
