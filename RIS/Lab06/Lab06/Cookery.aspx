<%@ Page AutoEventWireup="true" CodeBehind="Cookery.aspx.cs" Inherits="Lab06.Cookery"
	Language="C#" %>

<!DOCTYPE html>
<html>
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<asp:EntityDataSource ConnectionString="name=CookeryModelContainer" DefaultContainerName="CookeryModelContainer"
			EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True"
			EntitySetName="Dishes" EntityTypeFilter="Dish" ID="CookeryDataSource" runat="server" />
		<table border="1" runat="server" style="background-color: #FFFFFF; border-collapse: collapse;
			border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
			<tr style="background-color: #DCDCDC; color: #000000;">
				<th>
					Поиск по названию
				</th>
				<th>
					<asp:TextBox ID="FilterTextBox" runat="server" />
				</th>
				<th>
					<asp:Button ID="FilterButton" OnClick="FilterButton_OnClick" runat="server" Text="Поиск" />
					<asp:Button ID="ClearButton" OnClick="ClearButton_OnClick" runat="server" Text="Очистить" />
				</th>
			</tr>
		</table>
		<br />
		<asp:ListView DataKeyNames="Id" DataSourceID="CookeryDataSource" ID="CookeryListView"
			InsertItemPosition="LastItem" runat="server">
			<AlternatingItemTemplate>
				<tr style="background-color: #FFF8DC; vertical-align: top;">
					<td>
						<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
					</td>
					<td>
						<asp:Label ID="IngridientsLabel" runat="server" Text='<%# Eval("Ingridients") %>' />
					</td>
					<td>
						<asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
					</td>
					<td>
						<asp:CheckBox ID="IsBoughtCheckBox" runat="server" Checked='<%# Eval("IsBought") %>'
							Enabled="False" />
					</td>
					<td>
						<asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Изменить" />
						<asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Удалить" />
					</td>
				</tr>
			</AlternatingItemTemplate>
			<EditItemTemplate>
				<tr style="background-color: #008A8C; color: #FFFFFF; vertical-align: top;">
					<td>
						<asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
					</td>
					<td>
						<asp:TextBox ID="IngridientsTextBox" Rows="5" runat="server" Text='<%# Bind("Ingridients") %>'
							TextMode="MultiLine" />
					</td>
					<td>
						<asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
					</td>
					<td>
						<asp:CheckBox ID="IsBoughtCheckBox" runat="server" Checked='<%# Bind("IsBought") %>' />
					</td>
					<td>
						<asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Сохранить" />
						<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Отменить" />
					</td>
				</tr>
			</EditItemTemplate>
			<EmptyDataTemplate>
				<table style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999;
					border-style: none; border-width: 1px;">
					<tr>
						<td>
							No data was returned.
						</td>
					</tr>
				</table>
			</EmptyDataTemplate>
			<InsertItemTemplate>
				<tr style="vertical-align: top">
					<td>
						<asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
					</td>
					<td>
						<asp:TextBox ID="IngridientsTextBox" Rows="5" runat="server" Text='<%# Bind("Ingridients") %>'
							TextMode="MultiLine" />
					</td>
					<td>
						<asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
					</td>
					<td>
						<asp:CheckBox Checked='<%# Bind("IsBought") %>' Enabled="False" ID="IsBoughtCheckBox"
							runat="server" />
					</td>
					<td>
						<asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Добавить" />
						<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Очистить" />
					</td>
				</tr>
			</InsertItemTemplate>
			<ItemTemplate>
				<tr style="background-color: #DCDCDC; color: #000000; vertical-align: top;">
					<td>
						<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
					</td>
					<td>
						<asp:Label ID="IngridientsLabel" runat="server" Text='<%# Eval("Ingridients") %>' />
					</td>
					<td>
						<asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
					</td>
					<td>
						<asp:CheckBox ID="IsBoughtCheckBox" runat="server" Checked='<%# Eval("IsBought") %>'
							Enabled="False" />
					</td>
					<td>
						<asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Изменить" />
						<asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Удалить" />
					</td>
				</tr>
			</ItemTemplate>
			<LayoutTemplate>
				<table border="1" runat="server" style="background-color: #FFFFFF; border-collapse: collapse;
					border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
					<tr style="background-color: #DCDCDC; color: #000000;">
						<th>
							Название блюда
						</th>
						<th>
							Ингридиенты
						</th>
						<th>
							Цена
						</th>
						<th>
							Куплено
						</th>
						<th>
							&nbsp;
						</th>
					</tr>
					<tr id="itemPlaceholder" runat="server">
					</tr>
				</table>
			</LayoutTemplate>
			<SelectedItemTemplate>
				<tr style="background-color: #008A8C; font-weight: bold; color: #FFFFFF; vertical-align: top;">
					<td>
						<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
					</td>
					<td>
						<asp:Label ID="IngridientsLabel" runat="server" Text='<%# Eval("Ingridients") %>' />
					</td>
					<td>
						<asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
					</td>
					<td>
						<asp:CheckBox ID="IsBoughtCheckBox" runat="server" Checked='<%# Eval("IsBought") %>'
							Enabled="False" />
					</td>
					<td>
						<asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
						<asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
					</td>
				</tr>
			</SelectedItemTemplate>
		</asp:ListView>
	</div>
	</form>
</body>
</html>
