<%@ Page Language="C#" MasterPageFile="~/admincp/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Supporter.aspx.cs" Inherits="ThietKeSoUI.admincp.Supporter" Title="Supporter Thietkeso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="cMainContent" ContentPlaceHolderID="cphMainContent" runat="server">
    <script language="javascript" type="text/javascript">
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
        }        
    </script>

    <h2 style="margin-bottom:5px"> <a href="Default.aspx">Home</a> &raquo; <a href="Supporter.aspx" class="active">Supporter</a></h2>    
    <h3>Quản Lý Supporter Online</h3>
    	    <table cellpadding="0" cellspacing="0" border=1>
			    <tr style="background-color:black">
                    <td><b>HỌ VÀ TÊN</b></td>
                    <td><b>YAHOO</b></td>
                    <td><b>MOBILE</b></td>
                    <td class="action" colspan=3>
                        <b>CHỈNH SỬA</b>
                    </td>
                </tr>  
                <asp:Label ID="lbTableSupporter" runat="server"></asp:Label>                                   
            </table>
		    
		    
		    <div id="panelEdit" style="display:none">
		    <h3>Sửa Profile Supporter</h3>
    	        <fieldset>
        	        <p><label>Họ và tên:</label><asp:TextBox ID="tbName" runat="server" CssClass="text-long" ></asp:TextBox></p>
        	        <p><label>Yahoo:</label><asp:TextBox ID="tbYahoo" runat="server" CssClass="text-medium" ></asp:TextBox></p>
        	        <p><label>Skype:</label><asp:TextBox ID="tbSkype" runat="server" CssClass="text-medium" ></asp:TextBox></p>
        	        <p><label>Mail:</label><asp:TextBox ID="tbMail" runat="server" CssClass="text-long" ></asp:TextBox></p>
                    <p><label>Mobile:</label><asp:TextBox ID="tbMobile" runat="server" CssClass="text-long" ></asp:TextBox></p>
                    <asp:Button ID="btnEdit" runat="server" Text="Sửa"  OnClick="btnEdit_Click" />
                </fieldset>                 
             </div>
             
             
             <div id="SomeHidden" style="display:none">
                <asp:HiddenField ID="hdEditID" runat="server" Value="0" />
             </div>
</asp:Content>

<asp:Content ID="cActiveMenuJs" ContentPlaceHolderID="cphActiveMenuJs" runat="server">
    <script language="javascript" type="text/javascript">
        var liMenu = document.getElementById('liSupporter');
        liMenu.className = 'active';
    </script>
</asp:Content>