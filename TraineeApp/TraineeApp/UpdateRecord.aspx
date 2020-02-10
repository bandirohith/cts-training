<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateRecord.aspx.cs" Inherits="TraineeApp.UpdateRecord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <table>
            <tr>
                 <td><asp:Label ID="Label1" runat="server" Text="Tid"></asp:Label></td>  
                 <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>  
                 <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr> 
            </table>
        <asp:Button ID="Button1" runat="server" Text="Upadte" OnClick="update_rec" />
       
        </div>
</asp:Content>
    

