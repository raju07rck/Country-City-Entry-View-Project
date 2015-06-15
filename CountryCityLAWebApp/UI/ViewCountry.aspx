<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCountry.aspx.cs" Inherits="CountryCityLAWebApp.UI.ViewCountry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Country View</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td><asp:Label ID="name" runat="server" Text="Name"></asp:Label></td>
                <td><asp:TextBox ID="searchCountryNameTextBox" runat="server" OnTextChanged="searchCountryNameTextBox_TextChanged"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="searchviewCountryButton" runat="server" Text="Search" Width="168px" />
        <br />
    </div>
        <div>
            <asp:GridView ID="viewCountryGridView" runat="server"></asp:GridView>
        </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    </form>
</body>
</html>
