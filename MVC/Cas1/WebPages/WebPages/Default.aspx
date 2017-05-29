<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPages._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="lblFirstName" runat="server" AssociatedControlID="txtFirstName" BorderColor="Red" BorderStyle="Dotted" BorderWidth="5px" Text="First Name"></asp:Label>
    <asp:TextBox ID="txtFirstName" runat="server"  Width="161px"></asp:TextBox>
    <br />
    <asp:Label ID="lblLastName" runat="server" AssociatedControlID="txtLastName" BorderColor="Red" BorderStyle="Dotted" BorderWidth="5px" ClientIDMode="Static" Text="Last Name"></asp:Label>
    <asp:TextBox ID="txtLastName" runat="server" ></asp:TextBox>
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Say Hi" />
    <asp:Calendar ID="cldDate" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
        <NextPrevStyle VerticalAlign="Bottom" />
        <OtherMonthDayStyle ForeColor="#808080" />
        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
        <SelectorStyle BackColor="#CCCCCC" />
        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
        <WeekendDayStyle BackColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Label ID="lblNovaLabela" runat="server" Text="Nova labela"></asp:Label>
    <asp:TextBox ID="txtResult" runat="server" ReadOnly="True"></asp:TextBox>

    <br />
    
</asp:Content>
