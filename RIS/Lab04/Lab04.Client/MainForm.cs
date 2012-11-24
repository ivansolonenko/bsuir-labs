using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

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

			txtDistrict.Enabled =
			txtTree.Enabled =
			txtAmount.Enabled = false;

			lbServiceInfo.Visible = false;
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			// Создаем объект класса NetworkStream и ассоциируем его объектом класса TcpClient
			NetworkStream ns;
			try
			{
				ns = TcpClient.GetStream();
			}
			catch (SocketException)
			{
				MessageBox.Show("The server is not started", "Connection Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var res = string.Empty;

			if (rbView.Checked)
				res = string.Format("view|");
			else if (rbAdd.Checked)
				res = string.Format("add|District: {0}; Tree: {1}; Amount: {2}", txtDistrict.Text, txtTree.Text, txtAmount.Text);

			// Создаем переменные типа byte[] для отправки запроса и получения результата
			var sent = Encoding.UTF8.GetBytes(res);
			var recieved = new byte[256];

			// Отправляем запрос на сервер
			ns.Write(sent, 0, sent.Length);

			// Получаем результат выполнения запроса с сервера
			ns.Read(recieved, 0, recieved.Length);

			// Отображаем полученный результат в клиентском RichTextBox
			rtbContent.Text += Encoding.UTF8.GetString(recieved) + Environment.NewLine;

			var status = string.Empty;
			if (rbView.Checked)
				status = "=> Command sent:view data";
			else if (rbAdd.Checked)
				status = "=> Command sent:add data";

			//Отображеем служебную информацию в клиентском ListBox
			lbServiceInfo.Items.Add(status);
		}

		private void rbView_CheckedChanged(object sender, EventArgs e)
		{
			if (!rbView.Checked)
				return;

			txtDistrict.Enabled =
			txtTree.Enabled =
			txtAmount.Enabled = false;
		}

		private void rbAdd_CheckedChanged(object sender, EventArgs e)
		{
			if (!rbAdd.Checked)
				return;

			txtDistrict.Enabled =
			txtTree.Enabled =
			txtAmount.Enabled = true;
		}

		private void cbShowStatus_CheckedChanged(object sender, EventArgs e)
		{
			lbServiceInfo.Visible = cbShowStatus.Checked;
		}
	}
}
