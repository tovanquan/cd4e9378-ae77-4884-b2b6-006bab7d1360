<%@ Page Language="C#" MasterPageFile="~/admincp/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="editArticleCtrl.aspx.cs" Inherits="ThietKeSoUI.admincp.editArticleCtrl" Title="Untitled Page" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 454px;
        }
        .style4
        {
            width: 2px;
        }
        .style5
        {
            width: 126px;
            height: 92px;
        }
        .style6
        {
        width: 454px;
        height: 92px;
    }
        .style7
        {
            width: 2px;
            height: 92px;
        }
        .style11
        {
            width: 126px;
        }
        .style12
        {
            width: 829px;
        }
        .style13
        {
            width: 128px;
        }
    </style>
    
    <script language="javascript" type="text/javascript">
        function SetHiddenFieldValue() {
            var contentValue = document.getElementById('<%=contentValue.ClientID%>');
            var editor = CKEDITOR.instances.<%=tbxContent.ClientID%>;
            contentValue.value = editor.getData();

        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
        <h2 style="margin-bottom:5px">
        <a href="Default.aspx">Home</a> » <a class="active" href="ArticleCtrl.aspx">
        Article</a></h2>
    <h3>
        Quản Lý Article</h3>
    <table style="width: 100%;">
        <tr>
            <td class="style11">
                Title</td>
            <td class="style3">
                <asp:TextBox ID="tbxTitle" runat="server" Width="100%"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style5">
                Summary</td>
            <td class="style6">
                <asp:TextBox ID="tbxSummary" runat="server" Height="105px" TextMode="MultiLine" 
                    Width="100%"></asp:TextBox>
            </td>
            <td class="style7">
                &nbsp;
            </td>
        </tr>
       
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
        </tr>
       
    </table>
    <div>
     <textarea runat="server" cols="30" id="tbxContent" name="tbxContent" rows="10">anh quan</textarea>
			<script type="text/javascript">
			    CKEDITOR.replace('<%= tbxContent.ClientID%>');
			</script>
    </div>
    <table>
        <tr>
            <td class="style13">
                Category</td>
            <td class="style3">
                <asp:DropDownList ID="cboCategory" runat="server" Width="30%">
                </asp:DropDownList>
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
       
        <tr>
            <td class="style13">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                    onclick="btnCancel_Click" />
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
    </table>
     <asp:HiddenField ID="contentValue" runat="server"/>
</asp:Content>
<asp:Content ID="cActiveMenuJs" ContentPlaceHolderID="cphActiveMenuJs" runat="server">

    <script language="javascript" type="text/javascript">
        var liMenu = document.getElementById('liArt');
        liMenu.className = 'active';
    </script>
</asp:Content>
