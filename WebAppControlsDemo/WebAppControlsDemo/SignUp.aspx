<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebAppControlsDemo.SignUp" %>
<asp:Content ID="id111" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Cannot be empty" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="vg">EnterName</asp:RequiredFieldValidator><br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <%--<asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" ForeColor="Red"></asp:CustomValidator>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>--%>
        <br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Enter age between 18 to 99" ControlToValidate="TextBox3" ForeColor="Red" MaximumValue="99" MinimumValue="18" Type="Integer" ValidationGroup="vg">Enter Age</asp:RangeValidator>
         <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter email" ControlToValidate="TextBox4" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vg"></asp:RegularExpressionValidator>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password" ControlToValidate="TextBox5" ForeColor="Red" ValidationGroup="vg">EnterPassword</asp:RequiredFieldValidator><br />
         
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
         <br />
         <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Enter the same Passworrd in password and confirm password" ControlToCompare="TextBox5" ControlToValidate="TextBox6" ForeColor="Red" ValidationGroup="vg">Enter password</asp:CompareValidator>
        <br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
         <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="vg" />


        <asp:Button ID="Button1" Text="Submit" runat="server" OnClick="Register_fun" />
    </div>
</asp:Content>
