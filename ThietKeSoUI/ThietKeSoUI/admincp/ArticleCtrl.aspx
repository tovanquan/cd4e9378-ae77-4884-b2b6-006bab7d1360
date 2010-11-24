<%@ Page Language="C#" MasterPageFile="~/admincp/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="ArticleCtrl.aspx.cs" Inherits="ThietKeSoUI.admincp.ArticleCtrl" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">

    <script language="javascript" type="text/javascript">
        function RedirectEditArticlePage(_id) {
            window.location = 'editArticleCtrl.aspx?ID=' + _id;

        }
        
        function doPostBackDelete(_id) {

            if (confirm("Do you want to delete this record?")) {
                var hdDelID = document.getElementById('<%=hdEditID.ClientID %>');
                hdDelID.value = _id;
                __doPostBack('ctl00$cphMainContent$lbtnDelete', '');
            }
           
              
          }        
    </script>
    
    <h2 style="margin-bottom:5px"> <a href="Default.aspx">Home</a> » <a href="ArticleCtrl.aspx" class="active">
        Tin Tức</a></h2>
   <h3>Ariticle Manager >> <a href="editArticleCtrl.aspx" >Add New</a></h3>
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
     </div>
      <asp:LinkButton ID="lbtnDelete" runat="server" Text="" OnClick="btn_Delete" 
        PostBackUrl="~/Article.aspx"/>
  
            
</asp:Content>
<asp:Content ID="cActiveMenuJs" ContentPlaceHolderID="cphActiveMenuJs" runat="server">

    <script language="javascript" type="text/javascript">
        var liMenu = document.getElementById('liArt');
        liMenu.className = 'active';
    </script>
</asp:Content>
