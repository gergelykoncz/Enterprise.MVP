<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebUI._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <fieldset>
        <legend>Search</legend>
        <p>
            Person name:
            <asp:TextBox runat="server" ID="tbox_name"></asp:TextBox></p>
        <p>
            <asp:Button runat="server" Text="Search" OnClick="Search_Click" />
        </p>
    </fieldset>
    <asp:GridView runat="server" ID="grid_persons">
    </asp:GridView>
</asp:Content>
