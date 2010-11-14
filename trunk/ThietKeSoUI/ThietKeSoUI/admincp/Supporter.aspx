<%@ Page Language="C#" MasterPageFile="~/admincp/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Supporter.aspx.cs" Inherits="ThietKeSoUI.admincp.Supporter" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="cMainContent" ContentPlaceHolderID="cphMainContent" runat="server">
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
					        <h3>Another section</h3>
                    	    <fieldset>
                        	    <p><label>Sample label:</label><input type="text" class="text-long" /></p>
                        	    <p><label>Sample label:</label><input type="text" class="text-medium" /><input type="text" class="text-small" /><input type="text" class="text-small" /></p>
                                <p><label>Sample label:</label>
                                <select>
                            	    <option>Select one</option>
                            	    <option>Select two</option>
                            	    <option>Select tree</option>
                            	    <option>Select one</option>
                            	    <option>Select two</option>
                            	    <option>Select tree</option>
                                </select>
                                </p>
                        	    <p><label>Sample label:</label><textarea rows="1" cols="1"></textarea></p>
                                <input type="submit" value="Submit Query" />
                            </fieldset>
</asp:Content>

<asp:Content ID="cActiveMenuJs" ContentPlaceHolderID="cphActiveMenuJs" runat="server">
    <script language="javascript" type="text/javascript">
        var liMenu = document.getElementById('liSupporter');
        liMenu.className = 'active';
    </script>
</asp:Content>