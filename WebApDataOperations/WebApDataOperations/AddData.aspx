<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddData.aspx.cs" Inherits="WebApDataOperations.AddData" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotran"> </div>
    <asp:Label ID="label1" runat="server" Text="Add Employees"></asp:Label>
    <br>
    <br>
    <br>
    <table>
       <tr>
           <td><asp:Label ID="label2" runat="server" Text="EmploeeId" style-margin="4px"></asp:Label></td>
           <td><asp:TextBox ID="TextBox1" runat="server" margin-left="5"></asp:TextBox></td>
     </tr><br />
        <tr>
             <td><asp:Label ID="label3" runat="server" Text="EmploeeName"></asp:Label></td>
            <td><asp:TextBox ID="TextBox2" runat="server" margin-left="5"></asp:TextBox></td>
        </tr>
        <tr>
             <td><asp:Label ID="label4" runat="server" Text="SSN"></asp:Label></td>
            <td><asp:TextBox ID="TextBox3" runat="server" margin-left="5"></asp:TextBox></td>
        </tr>
         <tr>
             <td><asp:Label ID="label5" runat="server" Text="EmploeeSalaray"></asp:Label></td>
            <td><asp:TextBox ID="TextBox4" runat="server" margin-left="5"></asp:TextBox></td>
        </tr>
         <tr>
             <td><asp:Label ID="label6" runat="server" Text="DOB"></asp:Label></td>
            <td><asp:TextBox ID="TextBox5" runat="server" margin-left="5"></asp:TextBox></td>
        </tr>
         <tr>
             <td><asp:Label ID="label7" runat="server" Text="DeptId"></asp:Label></td>
            <td><asp:TextBox ID="TextBox6" runat="server" margin-left="5"></asp:TextBox></td>
        </tr>
        
       
    </table>
    <asp:Button ID="button1" runat="server" Text="Add" OnClick="button1_click" />

</asp:Content>
