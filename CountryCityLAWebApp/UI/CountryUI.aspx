<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryUI.aspx.cs" Inherits="CountryCityLAWebApp.UI.CountryUI" %>

<html lang="en">

<head runat="server">
    <title>Country Entry</title>
    </head>
<body>
  
        <form id="form1" runat="server">
            <div class="container">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Country Name"></asp:Label>
            <asp:TextBox ID="countryNameTextBox" runat="server" Width="307px"></asp:TextBox>
    
            <br />
            <asp:Label ID="Label2" runat="server" Text="About Country"></asp:Label>
            <asp:TextBox ID="aboutCountryTextBox" runat="server" Height="54px" Width="308px"></asp:TextBox>
            <br />
            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
            <asp:Button ID="cancelButton" runat="server" Text="Cancel" OnClick="cancelButton_Click" />
            <asp:Label ID="msgLabel" runat="server" Text=" "></asp:Label>
            <br />
        </div>
        <div>
            <asp:GridView ID="countryinfoListGridView" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="454px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnSelectedIndexChanged="countryinfoListGridView_SelectedIndexChanged" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" Visible="False" />
                    <asp:BoundField DataField="Serial" HeaderText="Serial" SortExpression="Serial" />
                    <asp:BoundField DataField="CountryName" HeaderText="Country Name" SortExpression="CountryName" />
                    <asp:BoundField DataField="AboutCountry" HeaderText="About Country" SortExpression="AboutCountry" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView> 
        </div>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllCountrys" TypeName="CountryCityLAWebApp.DAL.countrygatewayDB"></asp:ObjectDataSource>
    </div>
            </form>
   
<!-- jQuery -->
    <script src="../Scripts/jquery.js"></script>
    <!-- Bootstrap Core JavaScript -->
    <script src="../Scripts/bootstrap.min.js"></script>
    <!-- Plugin JavaScript -->
    <script src="http://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>
    
    <script src="../Scripts/classie.js"></script>
    <script src="../Scripts/cbpAnimatedHeader.js"></script>
    <!-- Custom Theme JavaScript -->
    <script src="../Scripts/agency.js"></script>
</body>

</html>
