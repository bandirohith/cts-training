<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Validators.aspx.cs" Inherits="WebAppSample.Validators" %>

<asp:Content ID="id1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Must BE entered" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="vg">Enter Name</asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" ValidationGroup="vg" />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="vg" />
    </div>
</asp:Content>
