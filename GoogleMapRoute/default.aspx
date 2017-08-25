<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="GoogleMapRoute._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<table>
				<tr>
					<td>From</td>
					<td><asp:TextBox runat="server" ID="txtfrom" CssClass="form-control" ValidationGroup="googledirections"></asp:TextBox></td>
					<td></td>
					<td>To</td>
					<td><asp:TextBox runat="server" ID="txtto" CssClass="form-control" ValidationGroup="googledirections"></asp:TextBox></td>
					<td></td>
					<td><asp:Button runat="server" ID="btnGetDirections" OnClick="btnGetDirections_Click" CausesValidation="true" Text="Get Directions" ValidationGroup="googledirections" /></td>
				</tr>
				<tr>
					<td></td>
					<td><asp:RequiredFieldValidator runat="server" ID="reqtxtfrom" ControlToValidate="txtfrom" Display="Dynamic" SetFocusOnError="true" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
					<td></td>
					<td><asp:RequiredFieldValidator runat="server" ID="reqtxtto" ControlToValidate="txtfrom" Display="Dynamic" SetFocusOnError="true" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
					<td></td>
					<td></td>
					<td></td>
				</tr>
				<tr>
					<td>Duration:</td>
					<td><asp:Label runat="server" ID="lblDuration"></asp:Label></td>
					<td></td>
					<td></td>
					<td></td>
					<td></td>
					<td></td>
				</tr>
				<tr>
					<td>Distance:</td>
					<td><asp:Label runat="server" ID="lblDistance"></asp:Label></td>
					<td></td>
					<td></td>
					<td></td>
					<td></td>
					<td></td>
				</tr>
			</table>
        </div>
    </form>
</body>
</html>
