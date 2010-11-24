using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;
using thietkeso.Biz.Implements;
using System.Text;

namespace ThietKeSoUI.admincp
{
    public partial class TempCategories : System.Web.UI.Page
    {
        ITempCategoriesService iTempCateService = new TempCategoriesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateTableTemplateCategories();
            btnAddnew.Attributes.Add("onclick", "return ShowAddPanel()");
            btnCancel.Attributes.Add("onclick", "return HideAddPanel()");
                 
        }
       
        protected void CreateTableTemplateCategories()
        {
            CHRTList<TempCategoriesInfo> lstTempCateInfo = new CHRTList<TempCategoriesInfo>();
            lstTempCateInfo = iTempCateService.SelectAll();
            StringBuilder strTb = new StringBuilder();
            if (lstTempCateInfo != null && lstTempCateInfo.Count() > 0)
            {
                foreach (TempCategoriesInfo tempCateInfo in lstTempCateInfo)
                {
                    strTb.AppendFormat("<tr class=\"odd\"> <td>{0}</td> <td>{1}</td> <td class=\"action\"> <a onclick= \"DisplayEditPanel('{0}','{1}','{2}');\" href=\"#\" class=\"edit\">Edit</a> <a href=\"#\" class=\"delete\" onclick=\"DeleteTempCate('{2}');\">Delete</a>",
                        tempCateInfo.Name, //0 
                        tempCateInfo.Description, //1
                        tempCateInfo.ID); //2                   
                }
            }
            lbTableTempCate.Text = strTb.ToString();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            TempCategoriesInfo tempCategories = new TempCategoriesInfo();
            int _id = 0;
            int.TryParse(hdEditID.Value.Trim(), out _id);
            tempCategories.ID = _id;
            tempCategories.Name = tbName.Text.Trim();
            tempCategories.Description = tbDes.Text.Trim();
            iTempCateService.Update(tempCategories);
            Response.Redirect("TempCategories.aspx");
        }

        /// <summary>
        /// Event Button Add Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            TempCategoriesInfo tempCategories = new TempCategoriesInfo();
            tempCategories.Name = tbAddName.Text.Trim();
            tempCategories.Description = tbAddDes.Text.Trim();
            iTempCateService.Insert(tempCategories);
            Response.Redirect("TempCategories.aspx");
        }

        /// <summary>
        /// Event Link Button Delete Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(hdEditID.Value, out id);
            iTempCateService.Delete(id);
            Response.Redirect("TempCategories.aspx");
        }
    }
}
