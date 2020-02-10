<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormControls.aspx.cs" Inherits="WebAppControlsDemo.WebFormControls" %>

<asp:Content ID="id122" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
         <asp:Label ID="label1" runat="server" Text="Enter Name"></asp:Label>
        <br />
        <asp:TextBox ID="textName" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="label2" runat="server" Text="DOB"></asp:Label>
        <br />
        <asp:Calendar ID="calender1" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="label3" runat="server" Text="gender"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>TransGender</asp:ListItem>
         </asp:RadioButtonList>
        <br />
        <asp:Label ID="label4" runat="server" Text="Tick Mark Hobbies"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Cricket</asp:ListItem>
            <asp:ListItem>Cooking</asp:ListItem>
            <asp:ListItem>Racing</asp:ListItem>
            <asp:ListItem>Driving</asp:ListItem>
         </asp:CheckBoxList>
        <br />
        <asp:Label ID="label5" runat="server" Text="Education"></asp:Label>
         <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>High School</asp:ListItem>
            <asp:ListItem>PrimarySchool</asp:ListItem>
            <asp:ListItem>Secondary</asp:ListItem>
            <asp:ListItem>Graduation</asp:ListItem>
            <asp:ListItem>PostGraduation</asp:ListItem>
         </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="button1" runat="server" Text="Submit" OnClick="button_func" />
    </div>
    
</asp:Content>