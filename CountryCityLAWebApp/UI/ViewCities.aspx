<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCities.aspx.cs" Inherits="CountryCityLAWebApp.UI.ViewCities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>City View</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="searchByCityNameRadioButton" runat="server" Text="City Name" OnCheckedChanged="searchByCityNameRadioButton_CheckedChanged" />
        <asp:TextBox ID="searchCityTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click"/>
        <br />
        <asp:RadioButton ID="searchByCountryNameRadioButton" runat="server" Text="Country Name" OnCheckedChanged="searchByCountryNameRadioButton_CheckedChanged" />
        <asp:DropDownList ID="countryDropDownList" runat="server" Width="165px">
        </asp:DropDownList>
        <br/>
           <asp:GridView ID="viewCitiesGridView" runat="server" AllowPaging="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" PageSize="5" ForeColor="Black" Width="519px" OnSelectedIndexChanged="viewCitiesGridView_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerSettings Mode="NumericFirstLast" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
                <br />
            <asp:Label ID="msgLabel" runat="server"></asp:Label> 
    </div>
    </form>
</body>
</html>
