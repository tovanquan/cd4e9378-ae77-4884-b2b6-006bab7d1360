<%@ Page Language="C#" MasterPageFile="~/admincp/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="ArticleCtrl.aspx.cs" Inherits="ThietKeSoUI.admincp.ArticleCtrl" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <script language="javascript" type="text/javascript">
        function RedirectEditArticlePage(_id) {
            window.location = 'editArticleCtrl.aspx?ID=' + _id;

        }
        
        function doPostBackDelete(_id) {

            if (confirm('Do you want to delete the record?'))
             {
                var hdDelID = document.getElementById('<%=hdEditID.ClientID%>');
                hdEditID.value = idDelete;

            }
           
              
          }        
    </script>
    
    <h2 style="margin-bottom:5px"> <a href="Default.aspx">Home</a> » <a href="ArticleCtrl.aspx" class="active">
        Tin Tức</a></h2>
    <h3>Quản Lý Articles</h3>
    <table cellpadding="0" cellspacing="0" border=1>
			    <tr style="background-color:black">
                    <td><b>Title</b></td>
                    <td><b>Author</b></td>
                    <td><b>Creaate Date</b></td>
                    <td class="action" colspan=3>
                        <b>Edit</b>
                    </td>
                </tr>  
                <asp:Label ID="lbTableArticles" runat="server"></asp:Label>  
                                                 
            </table>
            
    
     <div id="SomeHidden" style="display:none">
     <asp:HiddenField ID="hdEditID" runat="server" Value="0" />                
         <asp:Button ID="btnDelete" runat="server" OnClick="btn_Delete"/>
     </div>
     <div>    <asp:Button ID="btnAddNew" runat="server" onclick="btnAddNew_Click" 
        Text="Add new" /></div>
  
            
</asp:Content>
<asp:Content ID="cActiveMenuJs" ContentPlaceHolderID="cphActiveMenuJs" runat="server">
    <script language="javascript" type="text/javascript">
        var liMenu = document.getElementById('liArt');
        liMenu.className = 'active';
    </script>
</asp:Content>
