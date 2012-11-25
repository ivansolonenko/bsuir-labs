<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyExchange.aspx.cs"
	Inherits="Lab06.CurrencyExchange" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
	<title>Lab06 Individual</title>
	<link href="~/Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
	<div class="navbar">
		<div class="navbar-inner">
			<asp:HyperLink CssClass="brand" NavigateUrl="~/CurrencyExchange.aspx" runat="server"
				Text="Currency Exchange" />
		</div>
	</div>
	<form id="CurrencyExchangeForm" runat="server">
	<div class="container">
		<div class="row">
			<div class="span4">
				<div class="control-group">
					<div class="controls">
						<div class="input-prepend">
							<span class="add-on">Из</span>
							<asp:DropDownList CssClass="span2" DataSourceID="CurrencyExchangeDataSource" DataTextField="Title"
								DataValueField="Rate" ID="ddlCurrencyFrom" runat="server" />
							<asp:RequiredFieldValidator ControlToValidate="ddlCurrencyFrom" Display="None" ErrorMessage="Выберите значение"
								runat="server" ValidationGroup="vgConverter" />
						</div>
						<div class="input-prepend">
							<span class="add-on">В</span>
							<asp:DropDownList CssClass="span2" DataSourceID="CurrencyExchangeDataSource" DataTextField="Title"
								DataValueField="Rate" ID="ddlCurrencyTo" runat="server" />
							<asp:RequiredFieldValidator ControlToValidate="ddlCurrencyFrom" Display="None" ErrorMessage="Выберите значение"
								runat="server" ValidationGroup="vgConverter" />
						</div>
						<div class="input-prepend">
							<span class="add-on">Сумма</span>
							<asp:TextBox CssClass="span3" ID="txtSumToConvert" runat="server" />
							<asp:RequiredFieldValidator ControlToValidate="txtSumToConvert" Display="None" ErrorMessage="Введите значение"
								runat="server" ValidationGroup="vgConverter" />
							<asp:RegularExpressionValidator ControlToValidate="txtSumToConvert" Display="None"
								ErrorMessage="Введите значение" runat="server" ValidationExpression="\d*" ValidationGroup="vgConverter" />
						</div>
						<asp:LinkButton CssClass="btn btn-primary" ID="btnConvert" OnClick="btnConvert_OnClick"
							runat="server" ValidationGroup="vgConverter">
							<i class="icon-random icon-white"></i>
							Конвертировать
						</asp:LinkButton>
						<asp:HyperLink CssClass="btn btn-warning" ID="btnCancel" NavigateUrl="~/CurrencyExchange.aspx"
							runat="server">
							<i class="icon-ban-circle icon-white"></i>
							Очистить
						</asp:HyperLink>
					</div>
				</div>
				<div class="control-group">
					<div class="controls">
						<div class="alert alert-success" id="divResult" runat="server" visible="False">
							<asp:Label ID="lblResult" runat="server" />
						</div>
					</div>
				</div>
			</div>
			<div class="span8">
				<asp:EntityDataSource ConnectionString="name=CurrencyExchangeModelContainer" DefaultContainerName="CurrencyExchangeModelContainer"
					EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True"
					EntitySetName="Currencies" EntityTypeFilter="Currency" ID="CurrencyExchangeDataSource"
					runat="server" />
				<asp:ListView DataKeyNames="Id" DataSourceID="CurrencyExchangeDataSource" ID="lvCurrencies"
					InsertItemPosition="LastItem" runat="server">
					<EditItemTemplate>
						<tr>
							<td>
								<asp:TextBox CssClass="input-medium" ID="txtTitle" runat="server" Text='<%# Bind("Title") %>' />
								<asp:RequiredFieldValidator ControlToValidate="txtTitle" Display="None" ErrorMessage="Введите значение"
									runat="server" ValidationGroup="vgEditItemTemplate" />
							</td>
							<td>
								<asp:TextBox CssClass="input-medium" ID="txtRate" runat="server" Text='<%# Bind("Rate") %>' />
								<asp:RequiredFieldValidator ControlToValidate="txtRate" Display="None" ErrorMessage="Введите значение"
									runat="server" ValidationGroup="vgEditItemTemplate" />
								<asp:RegularExpressionValidator ControlToValidate="txtRate" Display="None" ErrorMessage="Введите значение"
									runat="server" ValidationExpression="\d*" ValidationGroup="vgEditItemTemplate" />
							</td>
							<td>
								<asp:LinkButton CommandName="Update" CssClass="btn btn-success" ID="UpdateButton"
									runat="server" ValidationGroup="vgEditItemTemplate">
									<i class="icon-ok icon-white"></i>
									Сохранить
								</asp:LinkButton>
								<asp:LinkButton CommandName="Cancel" CssClass="btn btn-warning" ID="CancelButton"
									runat="server">
									<i class="icon-ban-circle icon-white"></i>
									Отменить
								</asp:LinkButton>
							</td>
						</tr>
					</EditItemTemplate>
					<InsertItemTemplate>
						<tr>
							<td>
								<asp:TextBox CssClass="input-medium" ID="txtTitle" runat="server" Text='<%# Bind("Title") %>' />
								<asp:RequiredFieldValidator ControlToValidate="txtTitle" CssClass="help-block" Display="None"
									ErrorMessage="Введите значение" runat="server" ValidationGroup="vgInsertItemTemplate" />
							</td>
							<td>
								<asp:TextBox CssClass="input-medium" ID="txtRate" runat="server" Text='<%# Bind("Rate") %>' />
								<asp:RequiredFieldValidator ControlToValidate="txtRate" CssClass="help-block" Display="None"
									ErrorMessage="Введите значение" runat="server" ValidationGroup="vgInsertItemTemplate" />
								<asp:RegularExpressionValidator ControlToValidate="txtRate" CssClass="help-block"
									Display="None" ErrorMessage="Введите значение" runat="server" ValidationExpression="\d*"
									ValidationGroup="vgInsertItemTemplate" />
							</td>
							<td>
								<asp:LinkButton CommandName="Insert" CssClass="btn btn-primary" ID="InsertButton"
									runat="server" ValidationGroup="vgInsertItemTemplate">
									<i class="icon-plus icon-white"></i>
									Добавить
								</asp:LinkButton>
								<asp:LinkButton CommandName="Cancel" CssClass="btn btn-warning" ID="CancelButton"
									runat="server">
									<i class="icon-ban-circle icon-white"></i>
									Очистить
								</asp:LinkButton>
							</td>
						</tr>
					</InsertItemTemplate>
					<ItemTemplate>
						<tr>
							<td>
								<asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title") %>' />
							</td>
							<td>
								<asp:Label ID="lblRate" runat="server" Text='<%# string.Format("{0:N}", Eval("Rate")) %>' />
							</td>
							<td>
								<asp:LinkButton CommandName="Edit" CssClass="btn btn-info" ID="EditButton" runat="server">
									<i class="icon-pencil icon-white"></i>
									Изменить
								</asp:LinkButton>
								<asp:LinkButton CommandName="Delete" CssClass="btn btn-danger" ID="DeleteButton"
									runat="server">
									<i class="icon-trash icon-white"></i>
									Удалить
								</asp:LinkButton>
							</td>
						</tr>
					</ItemTemplate>
					<LayoutTemplate>
						<table class="table table-bordered table-condensed table-striped" id="itemPlaceholderContainer"
							runat="server">
							<thead>
								<tr>
									<th>
										Валюта
									</th>
									<th>
										Курс
									</th>
									<th>
										&nbsp;
									</th>
								</tr>
							</thead>
							<tbody>
								<tr id="itemPlaceholder" runat="server">
								</tr>
							</tbody>
						</table>
					</LayoutTemplate>
				</asp:ListView>
			</div>
		</div>
	</div>
	</form>
</body>
</html>
