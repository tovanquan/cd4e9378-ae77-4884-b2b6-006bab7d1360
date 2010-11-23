<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="TempCategories.aspx.cs" Inherits="ThietKeSoUI.admincp.TempCategories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="tempCateContent" ContentPlaceHolderID="cphMainContent" runat="server">
<h2 style="margin-bottom:5px"> <a href="Default.aspx">Home</a> &raquo; <a href="TempCategories.aspx" class="active">Template Categories</a></h2>    
<h3>Manage Template Categories Online</h3>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<!-- Edit Function Start-->
<script language="javascript" type="text/javascript">
    function DisplayEditPanel(_name, _description, _id) {
        document.getElementById('panelEdit').style.display = 'block';
        
        var name = document.getElementById('<%=tbName.ClientID %>');
        name.value = _name;
        
        var description = document.getElementById('<%=tbDes.ClientID %>');
        description.value = _description;
        
        document.getElementById('<%=hdEditID.ClientID %>').value = _id;
    }
    function HideEditPanel() { document.getElementById('panelEdit').style.display = 'none'; }
</script>
    <table cellpadding="0" cellspacing="0" border=1>
	    <tr>
            <td><b>NAME</b></td>
            <td><b>DESCRIPTION</b></td>
            <td class="action" colspan=2>
                <b>FUNCTION</b>
            </td>
        </tr>  
        <asp:Label ID="lbTableTempCate" runat="server"></asp:Label>
    </table>
    
    <div align = "center" valign = "middle" >
        <asp:Button ID="btnAddnew" runat="server" Text="Addnew" />
    </div>       
                       	
    <div id="panelEdit" style="display:none">
		    <h3>Edit Template Categories</h3>
    	        <fieldset>
        	        <p><label>Name:</label><asp:TextBox ID="tbName" runat="server" CssClass="text-long" ></asp:TextBox></p>
        	        <p><label>Description:</label><asp:TextBox ID="tbDes" runat="server" CssClass="text-medium" ></asp:TextBox></p>
                    <asp:Button ID="btnEdit" runat="server" Text="Edit"  OnClick="btnEdit_Click" />
                </fieldset>                 
     </div>
     <div id="SomeHidden" style="display:none">
        <asp:HiddenField ID="hdEditID" runat="server" Value="0" />
     </div>
     
<!-- Edit Function End-->

<!-- Addnew Function Start-->
     <script language="javascript" type="text/javascript">
         function HideAddPanel() 
         {
             document.getElementById('panelAdd').style.display = 'none';
         }
         function ShowAddPanel() 
         {
             document.getElementById('panelAdd').style.display = 'block';
             HideEditPanel();
         }
     </script>

     <div id="panelAdd" style="display:none;">
        <h3>Add New Template Categories</h3>
        <fieldset>
	        <p><label>Name:</label><asp:TextBox ID="tbAddName" runat="server" CssClass="text-long" ></asp:TextBox></p>
	        <p><label>Description:</label><asp:TextBox ID="tbAddDes" runat="server" CssClass="text-medium" ></asp:TextBox></p>
            <asp:Button ID="btnAdd" runat="server" Text="Ok"  OnClick="btnAdd_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </fieldset>  
     </div>
<!-- Addnew Function End-->        
    
<!-- Delete Function Start-->
     
<!-- Delete Function End-->
</asp:Content>
