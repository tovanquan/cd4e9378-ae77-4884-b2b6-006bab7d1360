using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

using thietkeso.Biz.Services;
using thietkeso.Common.Models;

namespace ThietKeSoUI
{
    public partial class Article : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int aID = 0;
            try
            {
                int.TryParse(Request.QueryString["a"].ToString(), out aID);
            }
            catch
            {
                aID = 0;
            }
            // get aticle info from DB
            ArticlesInfo articleInfo = new ArticlesInfo();
            IArticlesService iArticlesService = new thietkeso.Biz.Implements.ArticlesService();
            articleInfo = iArticlesService.Select(aID);
            if (articleInfo != null)
            {
                // Set lable's text
                lbAuthor.Text = articleInfo.Author;
                lbContent.Text = articleInfo.Contents;
                lbLastModified.Text = articleInfo.CreateDate.ToString();
                lbSummary.Text = articleInfo.Summary;
                lbTitle.Text = articleInfo.Title;
            }
            else Response.Redirect("~/Default.aspx");
        }
    }
}
