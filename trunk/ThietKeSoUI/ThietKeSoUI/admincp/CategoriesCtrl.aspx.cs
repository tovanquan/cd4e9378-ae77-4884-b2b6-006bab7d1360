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
using TKSUltilities;
using TKSUltilities.Helper;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;
using System.Text;
using thietkeso.Biz.Implements;
namespace ThietKeSoUI.admincp
{
    public partial class CategoriesCtrl : System.Web.UI.Page
    {
        #region Properties
        /// <summary>
        /// categories service
        /// </summary>
        ICategoriesService iCategoriesService = new CategoriesService();
        #endregion

        #region Private method
        /// <summary>
        /// build categories table
        /// </summary>
        private void BuildTableCategoriesView()
        {
            try
            {
                //Create categories info
                CHRTList<CategoriesInfo> lstCategoryInfo = new CHRTList<CategoriesInfo>();

                //Select all data from table
                lstCategoryInfo = iCategoriesService.SelectAll();
                //String html to display
                StringBuilder strCategory = new StringBuilder();
                if (lstCategoryInfo != null && lstCategoryInfo.Count() > 0)
                {
                    foreach (var CategoryInfo in lstCategoryInfo)
                    {
                        strCategory.AppendFormat("<tr class=\"odd\">" +
                                                "<td>{0}</td><td>{1}</td><td>{2}</td>" +
                                                "<td class=\"action\"><a onclick=\"DisplayEditPanel('{1}','{2}','{0}');" +
                                                "\" href=\"#\" class=\"edit\">Edit</a><a href=\"#\"" +
                                                " class=\"delete\" onclick=\"DeleteCategory('{0}');\">Delete</a></td></tr>",
                            CategoryInfo.ID,//0
                            CategoryInfo.Name,//1
                            CategoryInfo.Description);//2
                    }
                }

                //Set text to display
                lbTableCategory.Text = strCategory.ToString();
            }
            catch (Exception) 
            {
                Response.Redirect("Error.aspx?msg=Somthing+Error+When+Load+Data");
            }
        }
        #endregion

        #region Event handle
        /// <summary>
        /// Page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BuildTableCategoriesView();
            }
        }

        /// <summary>
        ///Occurs when click upate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {              
                CategoriesInfo categoryInfo = new CategoriesInfo();
                int _id = 0;
                int.TryParse(hdEditID.Value.Trim(), out _id);
                if (_id > 0) //Update
                {
                    categoryInfo.ID = _id;
                    categoryInfo.Name = tbName.Text.Trim();
                    categoryInfo.Description = tbDes.Text.Trim();
                    iCategoriesService.Update(categoryInfo);
                    Response.Redirect("CategoriesCtrl.aspx");
                }
                else //Save
                {
                    categoryInfo.Name = tbName.Text.Trim();
                    categoryInfo.Description = tbDes.Text.Trim();
                    iCategoriesService.Insert(categoryInfo);
                    Response.Redirect("CategoriesCtrl.aspx");
                
                }
            }
            catch (System.Threading.ThreadAbortException)
            {

            }
            catch (Exception) 
            {
                Response.Redirect("Error.aspx?msg=Failed+To+Update+The+Category");
            }
        }

        /// <summary>
        /// Event Link Button Delete Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(hdDelID.Value, out id);
                iCategoriesService.Delete(id);
                Response.Redirect("CategoriesCtrl.aspx");
            }
            catch (System.Threading.ThreadAbortException)
            {

            }
            catch (Exception) 
            {
                Response.Redirect("Error.aspx?msg=Failed+To+Delete+The+Category");
            }
        }
        #endregion
    }
}
