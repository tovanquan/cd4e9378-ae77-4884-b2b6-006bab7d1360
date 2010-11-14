<%@ Page Language="C#" MasterPageFile="~/MasterPages/MasterPage.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ThietKeSoUI.Contact" Title="Liên Hệ - Thiết Kế Số" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBannerSlide" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cplMainArea" runat="server">
<div id="thietkeso_maincontent">
<!-- Trang chủ / liên hệ -->
    <h2>Liên Hệ</h2>
    <p class="contact">
        Xin hãy nhập thông tin của bạn vào form lên hệ bên dưới
    </p>
    
    <table border="0">
        <tbody valign="top">
        <tr>
            <td>Tên của bạn:
            <font style="color:Red">(*)</font></td>
            <td><asp:TextBox ID="tbName" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td>Địa chỉ:</td>
            <td><asp:TextBox ID="tbAddress" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email:<font style="color:Red">(*)</font></td>
            <td><asp:TextBox ID="tbEmail" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td>Điện thoại:</td>
            <td><asp:TextBox ID="tbTel" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td>Tiêu đề:<font style="color:Red">(*)</font></td>
            <td><asp:TextBox ID="tbTitle" runat="server" ></asp:TextBox></td>
        </tr>
        <tr >
            <td>Nội dung:<font style="color:Red">(*)</font></td>
            <td><asp:TextBox ID="tbContent" TextMode="MultiLine" Width="400px" Height="100px" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Label ID = "lbError" runat="server" Text="" style="color:Red" Visible ="false" ></asp:Label></td>
        </tr>
        <tr>
            <td></td><td> <asp:Button ID="btnSend" runat="server" Text="Gửi" 
                onclick="btnSend_Click" /></td>
        </tr>
        </tbody>
    </table>
    
    <p class="contact">
        Hoặc liên hệ trực tiếp:
    
    
    <div class="bottomlienhe">
        <p class="text2lienhe">
            <span class="">CÔNG TY TNHH CÔNG NGHỆ VÀ TRUYỀN THÔNG THIẾT KẾ SỐ</span>
            <br>
            Địa chỉ: 03/20 HỒ TÙNG MẬU - CẦU GIẤY - HÀ NỘI<br>
            Điện thoại: 0977.197.167 / 0987.550.986<br>
            Email: lienhe@thietkeso.net<br>
        </p>
    </div>
<!-- End Trang chủ / liên hệ -->
</div>
</asp:Content>
