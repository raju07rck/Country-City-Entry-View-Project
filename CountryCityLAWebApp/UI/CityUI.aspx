<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityUI.aspx.cs" Inherits="CountryCityLAWebApp.UI.CityUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>City Entry</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="cityNameTextBox" runat="server" Width="175px"></asp:TextBox></td>
            </tr>
            <br/>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="About"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="aboutCityTextBox" runat="server" Width="175px"></asp:TextBox></td>
            </tr>
            <br/>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="No. of dwellers"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="cityDwellersNoTextBox" runat="server" Width="175px"></asp:TextBox></td>
            </tr>
           <br/>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="Location"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="cityLocationTextBox" runat="server" Width="175px"></asp:TextBox></td>
            </tr>
            <br/>
             <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Weather"></asp:Label></td>
                <td class="auto-style1"><asp:TextBox ID="cityWeatherTextBox" runat="server" Width="175px"></asp:TextBox></td>
            </tr>
            <br/>
            <tr>
                <td><asp:Label ID="Label6" runat="server" Text="Location"></asp:Label></td>
                <td class="auto-style1"><asp:DropDownList ID="countryDropDownList" runat="server" Height="20px" Width="180px"></asp:DropDownList></td>
            </tr>
        
        </table>
        <br/>
         <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" Width="94px" style="margin-left: 100px" />
    
        <asp:Label ID="cmsgLabel" runat="server" Text=" "></asp:Label>
    
        <asp:Button ID="cancelButton" runat="server" Text="Cancel" OnClick="cancelButton_Click" Width="94px" />
    
        <br />
    
        <br />
    
    </div>
    <div>
        <asp:GridView ID="cityInfoListGridView" runat="server" Width="571px" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" PageSize="5">
            <Columns>
                <asp:BoundField DataField="CityId" HeaderText="CityId" SortExpression="CityId" Visible="False" />
                <asp:BoundField DataField="CitySerial" HeaderText="CitySerial" SortExpression="CitySerial" />
                <asp:BoundField DataField="CityName" HeaderText="CityName" SortExpression="CityName" />
                <asp:BoundField DataField="AboutCity" HeaderText="AboutCity" SortExpression="AboutCity" />
                <asp:BoundField DataField="CityDwellers" HeaderText="CityDwellers" SortExpression="CityDwellers" />
                <asp:BoundField DataField="CityLocation" HeaderText="CityLocation" SortExpression="CityLocation" />
                <asp:BoundField DataField="CityWeather" HeaderText="CityWeather" SortExpression="CityWeather" />
                <asp:BoundField DataField="CountryID" HeaderText="CountryID" SortExpression="CountryID" Visible="False" />
                <asp:BoundField DataField="CountryNameinCity" HeaderText="Country Name" SortExpression="CountryNameinCity" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerSettings Mode="NumericFirstLast" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllCitys" TypeName="CountryCityLAWebApp.DAL.CitygatewayDB"></asp:ObjectDataSource>
    </form>
</body>
</html>
