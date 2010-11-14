<%@ Page Language="C#" MasterPageFile="~/admincp/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="ArticleCtrl.aspx.cs" Inherits="ThietKeSoUI.admincp.ArticleCtrl" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <p>
        <asp:GridView ID="grdArticle" runat="server">
        </asp:GridView>
    </p>
</asp:Content>
