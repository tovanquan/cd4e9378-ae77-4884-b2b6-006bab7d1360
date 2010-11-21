<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ThietKeSoUI.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnHide" Runat="server" Text="Hide" />
        <asp:Button ID="btnShow" Runat="server" Text="Show" />
<script language="javascript" type="text/javascript">
function hideButton() {
    var a = document.getElementById("divAbc");
    a.style.visibility = "hidden";
return false;

}
function showButton() {
    if (document.all) {
        var a = document.getElementById("divAbc");
        a.style.visibility = "visible";
    }
}
</script>

<div id="divAbc" style ="visibility:hidden">
<table><tr><td style="width: 200px; height: 100px; background-color: red"></td></tr></table>

</div>
    </div>
    </form>
</body>
</html>
