/*
 * Create: To Van Quan
 * Date: 11/15/2010 
 */
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
using thietkeso.DAL;
using thietkeso.Common;
using thietkeso.Biz;
using thietkeso.Biz.Services;
using thietkeso.Common.Models;
using System.Text;
namespace ThietKeSoUI.admincp
{
    public partial class ArticleCtrl : System.Web.UI.Page
    {
        /// <summary>
        /// Articles Service
        /// </summary>
        private IArticlesService iArticlesService = new thietkeso.Biz.Implements.ArticlesService();

        protected void Page_Load(object sender, EventArgs e)
        {
            BuildTableArticleView();

        }

        /// <summary>
        /// Load list of articles fron database
        /// </summary>
        private void BuildTableArticleView() 
        {
            CHRTList<ArticlesInfo> lstArticlesInfo = new CHRTList<ArticlesInfo>();
            lstArticlesInfo = iArticlesService.SelectAll();
            StringBuilder strTS = new StringBuilder();
            if (lstArticlesInfo != null && lstArticlesInfo.Count() > 0)
            {
                foreach (ArticlesInfo temp in lstArticlesInfo)
                {
                    strTS.AppendFormat("<tr class=\"odd\"><td>{1}</td><td>{2}</td><td>{3}</td><td class=\"action\"><a onclick=\"RedirectEditArticlePage('{0}');\" href=\"#\" class=\"edit\">Edit</a><a onclick=\"doPostBackDelete('{0}');\" href=\"#\" class=\"delete\">Delete</a></td></tr>",
                        temp.ID, temp.Title, temp.Author, temp.CreateDate);
                }
            }
            lbTableArticles.Text = strTS.ToString();
          
            
        }

        protected void btn_Delete(object sender, EventArgs e)
        {
            int _id = 0;
            int.TryParse(hdEditID.Value.Trim(), out _id);
            iArticlesService.Delete(_id);
            
        }     
      
    }
}
