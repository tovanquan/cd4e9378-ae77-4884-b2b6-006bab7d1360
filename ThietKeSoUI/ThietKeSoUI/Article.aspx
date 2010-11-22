<%@ Page Language="C#" MasterPageFile="~/MasterPages/MasterPage.Master" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="ThietKeSoUI.Article" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="cBannerSlide" ContentPlaceHolderID="cphBannerSlide" runat="server">

</asp:Content>

<asp:Content ID="cMainArea" ContentPlaceHolderID="cplMainArea" runat="server">
<div id="thietkeso_maincontent">            
				<div id='article'>
					<h1>
					    <asp:Label ID="lbTitle" runat="server" Text="Title"></asp:Label>
					</h1>
					<div class='article_heading'>
						<asp:Label ID="lbAuthor" runat="server" Text="Author"></asp:Label>
						 |
						<asp:Label ID="lbLastModified" runat="server" Text="Date time" ></asp:Label>
					</div>
					<div class='article_summary'>
						<p>
                            <asp:Label ID="lbSummary" runat="server"
                                Text="Summary" ></asp:Label>							
						</p>
					</div>
					<div style='text-align:center'>
						<asp:Image ID="imgArticle" runat="server" CssClass="article_image" />
					</div>
					<div class='article_content'>
					    <asp:Label ID="lbContent" runat="server"
					        Text="article content" ></asp:Label>
					</div>
				</div>
</div>	        
</asp:Content>
