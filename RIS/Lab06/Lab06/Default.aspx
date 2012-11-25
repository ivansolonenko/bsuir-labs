<%@ Page AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab06.Default"
	Language="C#" Title="Home Page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>Lab06</title>
</head>
<body>
	<form id="DefaultForm" runat="server">
	<div style="text-align: center;">
		<p>
			<asp:Label ID="lblMessage" runat="server" />
		</p>
		<div>
			Введите ваше имя:
		</div>
		<div>
			<asp:TextBox ID="txtName" runat="server" />
		</div>
		<div>
			<asp:Button ID="btnHello" OnClick="btnHello_OnClick" runat="server" Text="Поздороваться!" />
		</div>
	</div>
	</form>
</body>
</html>
