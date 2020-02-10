<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApDataOperations.WebForm2" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent" runat="server" >

    <asp:label ID="label1" runat="server" Text="UpdateEmployee"></asp:label>
    <br>
    <br>
    <table>
        <tr>
            <td><asp:Label ID="label2" runat="server" Text="EmploeeId" style-margin="4px"></asp:Label></td>
           <td><asp:TextBox ID="T1" runat="server" margin-left="5"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="label3" runat="server" Text="EmployeeSalary" style-margin="4px"></asp:Label></td>
       
            
            <td><asp:TextBox ID="T2" runat="server" margin-left="5"></asp:TextBox></td>
        </tr>
        </table>
        <asp:Button ID="b1" runat="server" Text="update" OnClick="update_button" />
    
</asp:Content>
