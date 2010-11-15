<%@ Page Language="C#" MasterPageFile="~/admincp/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Supporter.aspx.cs" Inherits="ThietKeSoUI.admincp.Supporter" Title="Supporter Thietkeso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="cMainContent" ContentPlaceHolderID="cphMainContent" runat="server">
    <script language="javascript" type="text/javascript">
        function HideEditPanel() { document.getElementById('panelEdit').style.display = 'none'; }
        function HideAddPanel() { document.getElementById('panelAdd').style.display = 'none'; }
        
        function DisplayEditPanel(_name,_yahoo,_skype,_mail, _mobile,_id) {
            document.getElementById('panelEdit').style.display = 'block';
            var name = document.getElementById('<%=tbName.ClientID %>');
            name.value = _name;
            var yahoo = document.getElementById('<%=tbYahoo.ClientID %>');
            yahoo.value = _yahoo;
            var skype = document.getElementById('<%=tbSkype.ClientID %>');
            skype.value = _skype;
            var mail = document.getElementById('<%=tbMail.ClientID %>');
            mail.value = _mail;
            var mobile = document.getElementById('<%=tbMobile.ClientID %>');
            mobile.value = _mobile;
            document.getElementById('<%=hdEditID.ClientID %>').value = _id;
            HideAddPanel();
        }
        function DeleteSupporter(idDelete) {
            var lbtnDelete = document.getElementById('<%=lbtnDelete.ClientID %>');
            if (confirm("Do you want to delete this record?")) {
                var hdDelID = document.getElementById('<%=hdDelID.ClientID %>');
                hdDelID.value = idDelete;
                __doPostBack('ctl00$cphMainContent$lbtnDelete', '');
            }
        }
        function ShowAddPanel() {
            document.getElementById('panelAdd').style.display = 'block';
            HideEditPanel();
        }
        
    </script>

    <h2 style="margin-bottom:5px"> <a href="Default.aspx">Home</a> &raquo; <a href="Supporter.aspx" class="active">Supporter</a></h2>    
    <h3>Manage Supporter >> <a href="javascript:ShowAddPanel();" > Add New</a></h3>
            
            
    	    <table cellpadding="0" cellspacing="0" border=1>
			    <tr style="background-color:black">
                    <td><b>NAME</b></td>
                    <td><b>YAHOO</b></td>
                    <td><b>MOBILE</b></td>
                    <td class="action" colspan=3>
                        <b>ACTION</b>
                    </td>
                </tr>  
                <asp:Label ID="lbTableSupporter" runat="server"></asp:Label>                                   
            </table>
		    <br />
		    
		    <div id="panelEdit" style="display:none">
		    <h3>Edit Supporter</h3>
    	        <fieldset>
        	        <p><label>Display Name:</label><asp:TextBox ID="tbName" runat="server" CssClass="text-long" ></asp:TextBox></p>
        	        <p><label>Yahoo:</label><asp:TextBox ID="tbYahoo" runat="server" CssClass="text-medium" ></asp:TextBox></p>
        	        <p><label>Skype:</label><asp:TextBox ID="tbSkype" runat="server" CssClass="text-medium" ></asp:TextBox></p>
        	        <p><label>Mail:</label><asp:TextBox ID="tbMail" runat="server" CssClass="text-long" ></asp:TextBox></p>
                    <p><label>Mobile:</label><asp:TextBox ID="tbMobile" runat="server" CssClass="text-long" ></asp:TextBox></p>
                    <asp:Button ID="btnEdit" runat="server" Text="Ok"  OnClick="btnEdit_Click" />
                    <input type="button" value="Cancel" onclick="HideEditPanel();" />
                </fieldset>                 
            </div>
             
            <div id="panelAdd" style="display:none;">
                <h3>Add New Supporter</h3>
    	        <fieldset>
        	        <p><label>Display Name:</label><asp:TextBox ID="tbName2" runat="server" CssClass="text-long" ></asp:TextBox></p>
        	        <p><label>Yahoo:</label><asp:TextBox ID="tbYahoo2" runat="server" CssClass="text-medium" ></asp:TextBox></p>
        	        <p><label>Skype:</label><asp:TextBox ID="tbSkype2" runat="server" CssClass="text-medium" ></asp:TextBox></p>
        	        <p><label>Mail:</label><asp:TextBox ID="tbMail2" runat="server" CssClass="text-long" ></asp:TextBox></p>
                    <p><label>Mobile:</label><asp:TextBox ID="tbMobile2" runat="server" CssClass="text-long" ></asp:TextBox></p>
                    <asp:Button ID="btnAdd" runat="server" Text="Ok"  OnClick="btnAdd_Click" />
                    <input type="button" value="Cancel" onclick="HideAddPanel();" />
                </fieldset>  
            </div>
             <asp:LinkButton ID="lbtnDelete" runat="server" Text="" OnClick="lbtnDelete_Click" ></asp:LinkButton>
             <div id="SomeHidden" style="display:none">
                <asp:HiddenField ID="hdEditID" runat="server" Value="0" />
                <asp:HiddenField ID="hdDelID" runat="server" Value="0" />
             </div>
</asp:Content>

<asp:Content ID="cActiveMenuJs" ContentPlaceHolderID="cphActiveMenuJs" runat="server">
    <script language="javascript" type="text/javascript">
        var liMenu = document.getElementById('liSupporter');
        liMenu.className = 'active';
    </script>
</asp:Content>