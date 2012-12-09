using System;
using System.Web.UI;

namespace Lab06
{
	public partial class Cookery : Page
	{
		protected void FilterButton_OnClick(object sender, EventArgs e)
		{
			CookeryDataSource.WhereParameters.Clear();
			CookeryDataSource.AutoGenerateWhereClause = true;
			CookeryDataSource.WhereParameters.Add("Name", TypeCode.String, FilterTextBox.Text);
		}

		protected void ClearButton_OnClick(object sender, EventArgs e)
		{
			CookeryDataSource.WhereParameters.Clear();
			FilterTextBox.Text = null;
		}
	}
}