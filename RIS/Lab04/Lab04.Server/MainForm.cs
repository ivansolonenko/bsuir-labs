using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Lab04.Server.Properties;

namespace Lab04.Server
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void txtListen_Click(object sender, EventArgs e)
		{
			txtListen.Text = Resources.MainForm_txtListen_Click_Listening;
			txtListen.Enabled =
			rbThreadClass.Enabled =
			rbMediaLibraryClass.Enabled = false;

			bwListener.RunWorkerAsync();
		}

		private void bwListener_DoWork(object sender, DoWorkEventArgs e)
		{
			WaitCallback callBack;

			if (rbThreadClass.Checked)
				callBack = ThreadClass.ThreadOperations;
			else if (rbMediaLibraryClass.Checked)
				callBack = MediaLibraryClass.ThreadOperations;
			else
				throw new ApplicationException();

			// Создаем новый TCP_Listener который принимает запросы от любых IP адресов и слушает по порту 5555
			var listener = new TcpListener(IPAddress.Any, 5555);
			// Активация listen’ера
			listener.Start();

			//int counter;
			while (true)
			{
				//richTextBox1.Text += Resources.MainForm_bwListener_DoWork_Waiting_for_a_connection + Environment.NewLine;

				// При появлении клиента добавляем в очередь потоков его обработку.
				ThreadPool.QueueUserWorkItem(callBack, listener.AcceptTcpClient());

				// Выводим информацию о подключении.
				//richTextBox1.Text += Resources.MainForm_bwListener_DoWork_Connection_No + ++counter + Environment.NewLine;
			}
		}
	}
}
