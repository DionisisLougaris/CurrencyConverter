<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Layout.css">
    <title>Currency Conversion</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="titleLabel" runat="server" Text="Currency Conversion"></asp:Label>
        <br />
        <br />
        <asp:Label class="labels" ID="Label2" runat="server" Text="Convert "></asp:Label>&nbsp;<asp:TextBox ID="amountTextBox" runat="server" Width="84px"></asp:TextBox>
        &nbsp;&nbsp; <asp:Label class="labels" ID="Label6" runat="server" Text="from: "></asp:Label>
        &nbsp; <asp:DropDownList ID="fromList" runat="server"  AutoPostBack="True"></asp:DropDownList>
        <br />
        <br />
        <asp:Label class="labels" ID="Label3" runat="server" Text="to: "></asp:Label>&nbsp; <asp:DropDownList ID="toList" runat="server" AutoPostBack="True"></asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Convert" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label class="labels" ID="Label4" runat="server" Text="Result: "></asp:Label>&nbsp; <asp:Label class="labels" ID="outputLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
