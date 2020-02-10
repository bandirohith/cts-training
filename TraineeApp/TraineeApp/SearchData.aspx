<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchData.aspx.cs" Inherits="TraineeApp.SearchData" %>

<asp:Content ID="id2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <%--<table>
            <tr>
                 <td><asp:Label ID="Label1" runat="server" Text="Tid"></asp:Label></td>  
                 <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
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
             </table>--%>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Search_rec" />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <br />
        <br />
           <p><a href="InsertData.aspx" class="btn btn-primary btn-lg">Show table &raquo;</a></p>
         <p><a href="UpdateRecord.aspx" class="btn btn-primary btn-lg">update table &raquo;</a></p>
        </div>
      </asp:content>