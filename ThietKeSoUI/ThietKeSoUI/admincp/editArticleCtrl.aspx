﻿<%@ Page Language="C#" MasterPageFile="~/admincp/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="editArticleCtrl.aspx.cs" Inherits="ThietKeSoUI.admincp.editArticleCtrl" Title="Untitled Page" ValidateRequest="false" %>
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
        
     function CheckInput() {
         SetHiddenFieldValue();
         var title = document.getElementById('<%=tbxTitle.ClientID %>').value;
         var summary = document.getElementById('<%=tbxSummary.ClientID %>').value;         
         var content = document.getElementById('<%=contentValue.ClientID %>').value;      
         var uploadFile = document.getElementById('<%=uploadedFile.ClientID %>').value;
         var btnSave = document.getElementById('<%=btnSave.ClientID %>').value;
         if(btnSave == 'Save')
         {
            if(uploadFile =='')
                    {
                    alert('Hay chon file anh!');
                    return false;
                    }
         }
         if (title.replace(/^\s+|\s+$/g, '') == '' || summary.replace(/^\s+|\s+$/g, '') == ''|| content.replace(/^\s+|\s+$/g, '') == '') {
             alert('Điền đầy đủ thông tin đi cụ!');
             return false;
         }
         return true;
      }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
        <h2>
        <a href="Default.aspx">Home</a> » <a class="active" href="ArticleCtrl.aspx">
            Article</a></h2>
    <h3>
        Edit Article</h3>
    <table style="width: 100%;">
        <tr>
            <td class="style11">
                Image</td>
            <td class="style3">
                <table style="width: 100%;">
                    <tr>
                        <td>
                            <asp:Image ID="image" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:FileUpload ID="uploadedFile" runat="server" />
                        </td>
                    </tr>
                </table>
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
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
                <asp:Label ID="message" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
       
        <tr>
            <td class="style13">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="btnSave" runat="server" Text="Save"  OnClientClick="return CheckInput();" onclick="btnSave_Click" />
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
