<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormRRK.aspx.cs" Inherits="Sample.WebFormRRK" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 452px;
            width: 992px;
        }
    </style>
</head>
<body style="height: 611px; width: 989px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
