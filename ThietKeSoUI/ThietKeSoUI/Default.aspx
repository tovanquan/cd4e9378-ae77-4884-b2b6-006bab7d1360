<%@ Page Language="C#" MasterPageFile="~/MasterPages/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ThietKeSoUI.Default" %>

<%@ Register src="~/UserControls/BannerSlide.ascx" tagname="BannerSlide" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="images/thietkeso-icon.png" type="image/ico" rel="shortcut icon" />
</asp:Content>
<asp:Content ID="cBannerSlide" ContentPlaceHolderID="cphBannerSlide" runat="server">
    <uc2:BannerSlide ID="BannerSlide1" runat="server" />
    <script src="../images/slide/predictadme.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cplMainArea" runat="server">
                <div class="box1">
	          	    <div class="box1top">
	            	    <h2>Thiết Kế Website</h2>
	          	    </div>
	                <div class="body">
	                    Start from<br />
	                    <span class="price">$4.75</span> per month
	                    <ul>
	                        <li>100 GB disk space</li>
	                        <li>1,000 GB bandwidth</li>
	                        <li>Host unlimited domains</li>                        
	                    </ul>
	                    <div class="readmore_black"><a href="subpage.html">Learn more</a></div>
				    </div>
	                <div class="boxbottom">
    	            	
	                </div>
	            </div>
                <div class="box2">
              	    <div class="box2top"><h2>Quảng Bá Website</h2></div>
	                    <div class="body">
	                    	    Start from<br />
	                            <span class="price">$9.75</span> per month
	                 		    <ul>
	                                <li>200 GB disk space</li>
	                                <li>2,000 GB bandwidth</li>
	                                <li>Host unlimited domains</li>                        
	                            </ul>
	                            <div class="readmore_black"><a href="subpage.html">Learn more</a></div>
					    </div>
                    <div class="boxbottom"></div>
        	    </div>
	            <div class="box1">
	          	    <div class="box1top">
	            	    <h2>Đăng Kí Tên Miền</h2>
	          	    </div>
	                <div class="body">
	                    Start from<br />
	                    <span class="price">$4.75</span> per month
	                    <ul>
	                        <li>100 GB disk space</li>
	                        <li>1,000 GB bandwidth</li>
	                        <li>Host unlimited domains</li>                        
	                    </ul>
	                    <div class="readmore_black"><a href="subpage.html">Learn more</a></div>
				    </div>
	                <div class="boxbottom">
    	            	
	                </div>
	            </div>
                <div class="box2">
              	    <div class="box2top"><h2>Lưu Trữ Web / Hosting</h2></div>
	                    <div class="body">
	                    	    Start from<br />
	                            <span class="price">$9.75</span> per month
	                 		    <ul>
	                                <li>200 GB disk space</li>
	                                <li>2,000 GB bandwidth</li>
	                                <li>Host unlimited domains</li>                        
	                            </ul>
	                            <div class="readmore_black"><a href="subpage.html">Learn more</a></div>
					    </div>
                    <div class="boxbottom"></div>
        	    </div>
</asp:Content>
