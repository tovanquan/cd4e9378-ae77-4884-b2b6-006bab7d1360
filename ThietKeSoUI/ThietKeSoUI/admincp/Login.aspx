<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ThietKeSoUI.admincp.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Đăng Nhập | ThietKeSo.net</title>
</head>
<body style="background-color:#ffffff;text-align:center;">
    <form id="form1" runat="server">
    <div  style="text-align:left; vertical-align:top;padding-top:20px;">
        Quản Trị Nội Dung | ThietKeSo JSC
        <br /><br />
        <table>
                <tr>
                    <td>UserName:</td>
                    <td><asp:TextBox ID="tbUserName" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><asp:TextBox ID="tbPassword" TextMode="Password" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnLogin" runat="server" Text="Login" 
                            onclick="btnLogin_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                            onclick="btnCancel_Click" />
                    </td>
                </tr>
            </table>
    </div>
    </form>
</body>
</html>
