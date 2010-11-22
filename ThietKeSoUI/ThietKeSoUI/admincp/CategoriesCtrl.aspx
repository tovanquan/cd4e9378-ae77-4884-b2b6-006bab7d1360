<%@ Page Language="C#" MasterPageFile="~/admincp/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="CategoriesCtrl.aspx.cs" Inherits="ThietKeSoUI.admincp.CategoriesCtrl" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
 <script language="javascript" type="text/javascript">
     function DisplayEditPanel(_name,_des, _id) {
         document.getElementById('panelEdit').style.display = 'block';
         var name = document.getElementById('<%=tbName.ClientID %>');
         name.value = _name;
         var yahoo = document.getElementById('<%=tbDes.ClientID %>');
         yahoo.value = _des;
         document.getElementById('<%=hdEditID.ClientID %>').value = _id;
         var btnEdit = document.getElementById('<%=btnEdit.ClientID %>');
         btnEdit.value = 'Update';
     }
     function DeleteSupporter(idDelete) {
         var lbtnDelete = document.getElementById('<%=lbtnDelete.ClientID %>');
         if (confirm("Do you want to delete thi record?")) {
             var hdDelID = document.getElementById('<%=hdDelID.ClientID %>');
             hdDelID.value = idDelete;
             __doPostBack('ctl00$cphMainContent$lbtnDelete', '');
         }
     }
     function ShowAddPanel() {
         document.getElementById('panelEdit').style.display = 'block';
         var name = document.getElementById('<%=tbName.ClientID %>');
         name.value = '';
         var yahoo = document.getElementById('<%=tbDes.ClientID %>');
         yahoo.value = '';
         var btnEdit = document.getElementById('<%=btnEdit.ClientID %>');
         btnEdit.value = 'Save';
         document.getElementById('<%=hdEditID.ClientID %>').value = '0';
     }
    </script>

    <h2 style="margin-bottom:5px">
        <a href="Default.aspx">Home</a> » <a class="active" href="ArticleCtrl.aspx">Categories</a></h2>
   <h3>Categories Manager >> <a href="javascript:ShowAddPanel();" >Add New</a></h3>
      <table cellpadding="0" cellspacing="0" border=1>
			    <tr style="background-color:black">
                    <td><b>ID</b></td>
                    <td><b>Name</b></td>
                    <td><b>Description</b></td>
                    <td class="action" colspan=3>
                        <b>Edit</b>
                    </td>
                </tr>  
                <asp:Label ID="lbTableCategory" runat="server"></asp:Label>                                                 
      </table>
      
       <div id="panelEdit" style="display:none">
		    <h3>Edit categories article</h3>
    	        <fieldset>
        	        <p><label>Name:</label><asp:TextBox ID="tbName" runat="server" CssClass="text-long" ></asp:TextBox></p>
        	        <p><label>Description:</label><asp:TextBox ID="tbDes" runat="server" TextMode="MultiLine" ></asp:TextBox></p>
        	        <asp:Button ID="btnEdit" runat="server" Text="Update"  OnClick="btnEdit_Click" />
                </fieldset>                 
           </div>           
             <asp:LinkButton ID="lbtnDelete" runat="server" Text="" OnClick="lbtnDelete_Click" ></asp:LinkButton>
            <div id="SomeHidden" style="display:none">
                <asp:HiddenField ID="hdEditID" runat="server" Value="0" />
                <asp:HiddenField ID="hdDelID" runat="server" Value="0" />
             </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphActiveMenuJs" runat="server">
  <script language="javascript" type="text/javascript">
      var liMenu = document.getElementById('liArtCat');
        liMenu.className = 'active';
    </script>
</asp:Content>
