<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelectAll.aspx.cs" Inherits="TraineeApp.SelectAll" %>

<asp:Content ID="id1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Button ID="Button1" runat="server" Text="GetAlltrainees" OnClick="Get_All" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
         <p><a href="InsertData.aspx" class="btn btn-primary btn-lg">Show table &raquo;</a></p>
         <p><a href="SearchData.aspx" class="btn btn-primary btn-lg">search table &raquo;</a></p>
        <p><a href="UpdateRecord.aspx" class="btn btn-primary btn-lg">update table &raquo;</a></p>
        </div>
    </asp:Content>