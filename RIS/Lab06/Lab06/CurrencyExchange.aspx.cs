using System;
using System.Web.UI;

namespace Lab06
{
	public partial class CurrencyExchange : Page
	{
		protected void btnConvert_OnClick(object sender, EventArgs e)
		{
			var sumToConvert = Convert.ToDouble(txtSumToConvert.Text);
			var rate1 = Convert.ToDouble(ddlCurrencyFrom.SelectedValue);
			var rate2 = Convert.ToDouble(ddlCurrencyTo.SelectedValue);

			divResult.Visible = true;
			lblResult.Text = string.Format("Результат: {0:N}", sumToConvert * rate1 / rate2);
		}
	}
}
