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
    public partial class editArticleCtrl : System.Web.UI.Page
    {
        /// <summary>
        /// Articles Service
        /// </summary>
        private IArticlesService iArticlesService = new thietkeso.Biz.Implements.ArticlesService();

        /// <summary>
        /// 
        /// </summary>
        private ICategoriesService iCategoryService = new thietkeso.Biz.Implements.CategoriesService();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Initialize();
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request["ID"]))//Update
            {
                int newID = int.Parse(Request["ID"]);
                ArticlesInfo dataInfo = iArticlesService.Select(newID);
                dataInfo.Author = "temp";
                dataInfo.Avatar = "temp";
                dataInfo.CategoryID = int.Parse(cboCategory.SelectedValue);
                dataInfo.Contents = contentValue.Value.Trim();
                dataInfo.CreateDate = DateTime.Now;
                dataInfo.Image = "temp";
                dataInfo.Summary = tbxSummary.Text.Trim();
                dataInfo.Title = tbxTitle.Text.Trim();
                iArticlesService.Update(dataInfo);
                Response.Redirect("ArticleCtrl.aspx");
            }
            else //Add new
            {
                ArticlesInfo dataInfo = new ArticlesInfo();
                dataInfo.Author = "temp";
                dataInfo.Avatar = "temp";
                dataInfo.CategoryID = int.Parse(cboCategory.SelectedValue);
                dataInfo.Contents = contentValue.Value.Trim();
                dataInfo.CreateDate = DateTime.Now;
                dataInfo.Image = "temp";
                dataInfo.Summary = tbxSummary.Text.Trim();
                dataInfo.Title = tbxTitle.Text.Trim();
                iArticlesService.Insert(dataInfo);
                Response.Redirect("ArticleCtrl.aspx");
            }

        }

        /// <summary>
        /// Init
        /// </summary>
        private void Initialize()
        {
            //them su kien javascript cho button save
            btnSave.Attributes.Add("onclick", "javascript: SetHiddenFieldValue();");


            //Get newID
            string strID = Request["ID"];

            cboCategory.DataSource = iCategoryService.SelectAll();
            cboCategory.DataValueField = "ID";
            cboCategory.DataTextField = "Name";
            cboCategory.DataBind();
            int newID;
            if (!string.IsNullOrEmpty(strID))
            {
                if (!int.TryParse(strID, out newID))
                {
                    Response.Redirect("Error.aspx?msg=Invalid+NewID");
                }
                else
                {
                    btnSave.Text = "Update";
                    GetNewData(newID);
                }
            }
            

        }

        private void GetNewData(int intNewID)
        {

            var newData = iArticlesService.Select(intNewID);
            if (newData != null)
            {
                tbxTitle.Text = newData.Title;
                tbxSummary.Text = newData.Summary;
                cboCategory.SelectedValue = newData.CategoryID + "";
                tbxContent.Value = newData.Contents;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArticleCtrl.aspx");
        }


    }
}
