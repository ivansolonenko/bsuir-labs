using System;
using System.Web.UI;

namespace Lab06
{
	public partial class Default : Page
	{
		protected void btnHello_OnClick(object sender, EventArgs e)
		{
			lblMessage.Text = "Добрый день, " + txtName.Text + ". Добро пожаловать в ASP.NET!";
		}
	}
}
