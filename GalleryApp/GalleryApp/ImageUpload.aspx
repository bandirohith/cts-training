<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ImageUpload.aspx.cs" Inherits="GalleryApp.ImageUpload" %>

<asp:Content ID="id1" ContentPlaceHolderID="MainContent" runat="server">
<div class="jumbotron">
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="upload" OnClick="ClickToUpload" />
    <br />
    <br />
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server"
                ImageUrl='<%# Eval("Name","~/Resources/{0} ")%>'
                width="350px" Height="350px"   />
            <br />
            <%# Eval("Name") %>
            
        </ItemTemplate>
    </asp:DataList>

    </div>
</asp:Content>

