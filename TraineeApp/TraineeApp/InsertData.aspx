<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertData.aspx.cs" Inherits="TraineeApp.InsertData" %>
<asp:Content ID="id1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <table>
            <tr>
                
                  
                 <td><asp:Label ID="Label1" runat="server" Text="Tid"></asp:Label></td>  
              
                 <td><asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></td>
                <td>  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Id must be Entered" ControlToValidate="TextBox1" ForeColor="#CC0000" ValidationGroup="vg"></asp:RequiredFieldValidator></td>
                
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>  
                 <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Location"></asp:Label></td>  
                 <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label4" runat="server" Text="TechDomain"></asp:Label></td>  
                 <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label5" runat="server" Text="StartDate"></asp:Label></td>  
                 <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
             </table>
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="insert_rec" ValidationGroup="vg" />

        <br />
        <br />
         <p><a href="SearchData.aspx" class="btn btn-primary btn-lg">search table &raquo;</a></p>
        <p><a href="UpdateRecord.aspx" class="btn btn-primary btn-lg">update table &raquo;</a></p>
               
            
       
    </div>
</asp:Content> 
